using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Windows;

namespace WpfStateViewModel.States
{
    public class CaptureNameState : ViewModelState
    {
        public CaptureNameState() : this(new Bug())
        {
        }

        public CaptureNameState(Bug bug) : base("CaptureName")
        {
            Bug = bug;
        }

        public ICommand NextCommand
        {
            get { return new InlineCommand(x => TransitionTo(new CaptureEmailState(Bug))); }
        }

        public Bug Bug { get; private set; }
    }
}
