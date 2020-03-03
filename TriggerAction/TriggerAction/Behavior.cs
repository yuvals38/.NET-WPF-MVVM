using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Interactivity;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media;

namespace TriggerActionDemo
{

public class TriggerActionClick : TriggerAction<CheckBox>
{
    protected override void Invoke(object parameter)
    {
        if (AssociatedObject.IsChecked == true)
            this.AssociatedObject.Foreground = Brushes.Green;
        else if (this.AssociatedObject.IsChecked == false)
            this.AssociatedObject.Foreground = Brushes.Red;
        else
            this.AssociatedObject.Foreground = Brushes.Black;
    }
}

}
