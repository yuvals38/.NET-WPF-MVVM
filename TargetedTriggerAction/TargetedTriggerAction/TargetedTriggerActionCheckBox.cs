using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Interactivity;
using System.Windows.Controls;

namespace TargetedTriggerAction
{
public class TargetedTriggerActionCheckBox : TargetedTriggerAction<TextBlock>
{
    protected override void Invoke(object parameter)
    {
        this.Target.Text = (this.AssociatedObject as CheckBox).IsChecked != null ? 
            (this.AssociatedObject as CheckBox).IsChecked.ToString()
            : "Null";
    }
}
}
