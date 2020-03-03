using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfStateViewModel
{
    public class InlineCommand : BindableCommand
    {
        private Action<object> _Execute = null;
        private Func<object, bool> _CanExecute = null;

        public InlineCommand(Action<object> execute)
        {
            if (execute == null)
                throw new ArgumentNullException("execute");

            _Execute = execute;
        }

        public InlineCommand(Action<object> execute, Func<object, bool> canExecute)
            : this(execute)
        {
            if (canExecute == null)
                throw new ArgumentNullException("canExecute");

            _CanExecute = canExecute;
        }

        public override bool CanExecute(object parameter)
        {
            bool results = true;

            if (_CanExecute != null)
                results = _CanExecute(parameter);

            return results;
        }

        public override void Execute(object parameter)
        {
            _Execute(parameter);
        }
    }
}
