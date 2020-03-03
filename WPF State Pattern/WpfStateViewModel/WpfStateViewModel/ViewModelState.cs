using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

using System.Windows;

namespace WpfStateViewModel
{
    public abstract class ViewModelState
    {
        public ViewModelState(string stateName)
        {
            if (string.IsNullOrEmpty(stateName))
                throw new ArgumentException("You must provide a state name.", "name");

            ViewModelStateName = stateName;
        }

        protected void TransitionTo(ViewModelState destination)
        {
            var handlers = ViewModelStateTransitioning;

            if (handlers != null)
                handlers(this, new ViewModelStateTransitioningEventArgs(destination));
        }

        public virtual ICommand ExitCommand
        {
            get { return new InlineCommand(OnExitCommand); }
        }

        public virtual ICommand CancelCommand
        {
            get
            {
                return new InlineCommand(x =>
                {
                    MessageBox.Show("Sorry to hear that you are not leaving a bug.", "Bye!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    TransitionTo(null);
                });
            }
        }

        protected void OnExitCommand(object argument)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exiting?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                Application.Current.Shutdown();
        }

        public string ViewModelStateName { get; private set; }
        public event EventHandler<ViewModelStateTransitioningEventArgs> ViewModelStateTransitioning = null;
    }
}
