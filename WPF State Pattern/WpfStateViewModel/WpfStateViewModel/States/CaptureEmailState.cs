using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace WpfStateViewModel.States
{
    public class CaptureEmailState : ViewModelState
    {
        public CaptureEmailState(Bug bug)
            : base("CaptureEmail")
        {
            Bug = bug;
        }

        public ICommand NextCommand
        {
            get { return new InlineCommand(x => TransitionTo(new CaptureTextState(Bug))); }
        }

        public Bug Bug { get; private set; }
    }
}
