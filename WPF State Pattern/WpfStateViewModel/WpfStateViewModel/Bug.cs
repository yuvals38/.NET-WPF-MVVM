using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace WpfStateViewModel
{
    public class Bug : INotifyPropertyChanged
    {
        private string _FirstName = null;
        private string _LastName = null;
        private string _Email = null;
        private string _Text = null;

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; OnPropertyChanged(); }
        }

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; OnPropertyChanged(); }
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value; OnPropertyChanged(); }
        }

        public string Text
        {
            get { return _Text; }
            set { _Text = value; OnPropertyChanged(); }
        }

        private void OnPropertyChanged()
        {
            var handlers = PropertyChanged;

            if (handlers != null)
                handlers(this, new PropertyChangedEventArgs(null));
        }

        public event PropertyChangedEventHandler PropertyChanged = null;
    }
}
