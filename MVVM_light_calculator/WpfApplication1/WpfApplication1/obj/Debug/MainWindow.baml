   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1  5   	        WpfApplication1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApplication1     5   	     � Title$  
MainWindow��5	   	   $	��350��6   $	��525��6)    � DataContext 5   	   �� *Main+   Locator �� Source# [  .��5
      � .+�5   
   �� -   5         ��Name$ 
lblCaption��5      $&�� Calculator Demo Using MVVM Light��6$   $
��Left=�6O   $��	37,10,0,0q�6j   $	��Top=�6}   $	��253��6�   �� 5   
   -   5        $ lblNum1��5      $��First Number��6!   $
��Left=�68   $��	27,57,0,0q�6S   $	��Top=�6f   �� 5   
   -   5         ��Name$ txtNum1��5      $
��Left=�6#   $��23��6>   $��
128,57,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6�   $	��162��6�   ��6r   �� *FirstNumber+6�   �� 5   
   -   5        $ lblNum2��5      $��Second Number��6!   $
��Left=�69   $��
27,111,0,0q�6T   $	��Top=�6h   �� 5   
   -   5        $ txtNum2��5      $
��Left=�6#   $��23��6>   $��128,111,0,0q�6J   $
 Wrap=�6_   $	��Top=�6�   $	��162��6�   ��6s   �� *SecondNumber+6�   �� 5   
   -   5         ��Name$ btnAddition��5      $��+��6&   $
��Left=�62   $��
27,168,0,0q�6M   $	��Top=�6a   $��75��6y   $��+��6�   ��6�   �� *	Operation+6�   �� 5   
   -   5        $ btnSubtraction��5      $��-��6)   $
��Left=�65   $��128,168,0,0q�6P   $	��Top=�6e   $��75��6}   $��-��6�   ��6�   �� *	Operation+6�   �� 5   
   -   5        $ btnMultiplication��5      $��*��6,   $
��Left=�68   $��226,168,0,0q�6S   $	��Top=�6h   $��75��6�   $��*��6�   ��6�   �� *	Operation+6�   �� 5   
   -	   5        $ btnDivision��5      $��/��6&   $
��Left=�62   $��324,168,0,0q�6M   $	��Top=�6b   $��75��6z   $��/��6�   ��6�   �� *	Operation+6�   5      5      