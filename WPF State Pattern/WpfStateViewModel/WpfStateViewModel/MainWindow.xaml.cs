using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

using WpfStateViewModel.States;

namespace WpfStateViewModel
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            TransitionTo(null);
        }

        private void TransitionTo(ViewModelState state)
        {
            if (State != null)
            {
                State.ViewModelStateTransitioning -= OnViewModelStateTransitioning;

                if (State is IDisposable)
                    ((IDisposable)State).Dispose();
            }

            if (state == null)
                state = new AskForBugState();

            State = state;
            State.ViewModelStateTransitioning += OnViewModelStateTransitioning;
            DataContext = state;
        }

        private void OnViewModelStateTransitioning(object sender, ViewModelStateTransitioningEventArgs args)
        {
            TransitionTo(args.State);
        }

        public ViewModelState State { get; private set; }
    }
}
