   M S B A M L   `   `   `  ����  WPF_MVVMLight_CRUD/    )WPF_MVVMLight_CRUD.Views.EmployeeInfoView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      k gGalaSoft.MvvmLight.Extras.WPF45, Version=4.3.31.28649, Culture=neutral, PublicKeyToken=0e27b6f8be9b2ef7+mvvm http://www.galasoft.ch/mvvmlight  5      "ignorehttp://www.ignore.com  5   	   $��446.866��5
   G   $��617.015��6X     � DataContext  6	   �� *Main+   Locator �� Source# [  .��5      �  � RowDefinitions 5   
   �� 5      $	��51* �6   �� 5      $	��42* �6   �� 5      $
��283* �6   �� 5      $	��71* �6   .+�5   
   �� $
��Wrap=�6    �� TextAlignment$ Center=�5      $��List of All Employees��6,   $
��Bold"�6I   $��30(�6[   �� 5   
   -   5         ��Name$ btnloadallemployees��5      $��List All Employees��6.   $��3��5      $��30(�6   $
��Bold"�5      ��5      �� *ReadAllCommand+&   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgemp��5      $��2��6"      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5      $��	0,10,0,28q�6#    J� RenderTransformOrigin$ 0.5,0.5&�66      
IsReadOnly . ��5   /   �� *	Employees+.  (System.Windows.Interactivity.Interaction	   Triggers	 5      /  )System.Windows.Interactivity.EventTrigger  5      
   	EventName$
 SelectionChanged��6!   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      /  )GalaSoft.MvvmLight.Command.EventToCommand     Command 5      �� *SendEmployeeCommand+ �� Mode$ OneWay=�   CommandParameter 5       ��  �� ElementName$ dgemp�� �� Path$ SelectedItem�5"      5$      �� 5%   
   $
��Left=�6   $��10,7,0,0q�6/   $��1��6A   $
��Wrap=�5&      $��EmpName to Search:��6(   $	��Top=�6B   $	��231��5'      �� 5(   
   $
��Left=�6   $��30��6-   $��	262,7,0,0q�69   $��1��5)       �� TextWrapping$
 Wrap=�6   $	��Top=�5*      $	��310��6*   ��5)   4   �� *	EmpName+ �� UpdateSourceTrigger$ PropertyChanged=�.��5*   6   	 5+        5,      $
 TextChanged��6!   . 5-         5.      �� *SearchCommand+$ OneWay=�50      .��51   &   52      53      54      