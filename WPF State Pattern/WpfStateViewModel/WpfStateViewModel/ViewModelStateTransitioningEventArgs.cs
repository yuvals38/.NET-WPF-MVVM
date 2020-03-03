using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfStateViewModel
{
    public class ViewModelStateTransitioningEventArgs : EventArgs
    {
        public ViewModelStateTransitioningEventArgs(ViewModelState state)
        {
            State = state;
        }

        public ViewModelState State { get; set; }
    }
}
