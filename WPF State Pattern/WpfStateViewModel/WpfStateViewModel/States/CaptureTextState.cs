using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Windows;

namespace WpfStateViewModel.States
{
    public class CaptureTextState : ViewModelState
    {
        public CaptureTextState(Bug bug)
            : base("CaptureText")
        {
            Bug = bug;
        }

        public override ICommand CancelCommand
        {
            get
            {
                return new InlineCommand(x =>
                {
                    MessageBox.Show("You want to quit after you came this far?", "Cancelling!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    TransitionTo(null);
                });
            }
        }

        public ICommand NextCommand
        {
            get { return new InlineCommand(x => TransitionTo(new ThanksState(Bug))); }
        }

        public Bug Bug { get; private set; }
    }
}
