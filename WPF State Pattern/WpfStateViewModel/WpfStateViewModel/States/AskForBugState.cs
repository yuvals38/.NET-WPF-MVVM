using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Windows;

namespace WpfStateViewModel.States
{
    public class AskForBugState : ViewModelState
    {
        public AskForBugState() : base("AskForBug")
        {
        }

        public ICommand LeaveBugCommand
        {
            get { return new InlineCommand(x => TransitionTo(new CaptureNameState())); }
        }

        public ICommand NoBugCommand
        {
            get { return new InlineCommand(x => MessageBox.Show("Okay - let us know when you want to post a bug", "Good to know!", MessageBoxButton.OK, MessageBoxImage.Asterisk)); }
        }
    }
}
