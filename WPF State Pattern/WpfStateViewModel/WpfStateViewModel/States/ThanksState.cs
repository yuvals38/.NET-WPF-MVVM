using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace WpfStateViewModel.States
{
    public class ThanksState : ViewModelState
    {
        public ThanksState(Bug bug)
            : base("Thanks")
        {
            Bug = bug;
        }

        public Bug Bug { get; private set; }

        public ICommand StartOverCommand
        {
            get { return new InlineCommand(x => TransitionTo(null)); }
        }
    }
}
