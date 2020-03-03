using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Windows;
using System.Windows.Input;

namespace WpfApplication1.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            Operation = new RelayCommand<string>((arg) => DoCalculation(arg));
        }
        public string FirstNumber { get; set; }
        public string SecondNumber { get; set; }
        public ICommand Operation { get; private set; }
        private void DoCalculation(string @operator)
        {
            var result = 0;
            switch (@operator)
            {
                case "+": result = Convert.ToInt32(FirstNumber) + Convert.ToInt32(SecondNumber); break;
                case "-": result = Convert.ToInt32(FirstNumber) - Convert.ToInt32(SecondNumber); break;
                case "*": result = Convert.ToInt32(FirstNumber) * Convert.ToInt32(SecondNumber); break;
                case "/": result = Convert.ToInt32(FirstNumber) / Convert.ToInt32(SecondNumber); break;
            }
            MessageBox.Show(result.ToString());
        }
    }
}