   M S B A M L   `   `   `  ����D  @Expenselt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Expenselt	Expenselt  5   	       Expenselt.ExpenseReport   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Expenselt     5   	     � Title$  Expenselt - View Report��5   	   $	��450��6)   $	��800��66   .��5	      � .+�5   
   �� $��304,0,-266,365q�6   $��20(�6(   
����  �$
��Bold"�6H   .��6Z   Expense Report for6n   �� 5   
   $
��Bold"�6.   $
��Left=�6@   $��26��6[   $��521,38,-521,313q�6g   ��6   ��  �� Path$
 Name�6�   �� 5   
   $
��Bold"�64   $
��Left=�6F   $��26��6a   $��125,48,0,328q�6m   $	��223��6�    J� RenderTransformOrigin$ -5.843,2.101&�6�   ��6   �� $ 
Department�6�   &   System.Windows.Controls.DataGrid  5   
   $��0��6      AutoGenerateColumns$ False��6F      RowHeaderWidth$ 0Q�6b   $��304,217,-222,155q�6u   ��6    �� $ Expense�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ExpenseType��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5      �� $ ExpenseType�  5      $ Amount��6%    65   �� $ ExpenseAmount�5      �� 5   
   $
��Bold"�6   
���   �$��Right=�65   $��31��6Q   $��0,121,-371,0q�6]   $��1��6s   $	��Top=�6�   $��80��6�   .��6�   
Department6�   � 5   
   ���	#FF4C0080$��10,103,-10,259q�6&   $��1��6>    � ColumnDefinitions 5      �� 5      $
��151* �6#   �� 5      $	��79* �6#   .+�5      �� $��Expense Type��6   
�������$��	0,15,0,10q�6>   $��2��6Q   �� 5       $��Amount��6   
�������$
��Left=�68   $��126,15,0,10q�6S   $	��104��6h   $��2��6t   5"      �� 5#   
   $
��Bold"�6   
���   �$��Right=�65   $��23��6Q   $��0,87,-348,0q�6]   $��1��6r   $	��Top=�6   $��54��6�   .��6�   Name6�   �� 5$   
   $
��Left=�6   $��13��6+   $��
250,82,0,0q�67   $	��Top=�6K   $��77��6c   .��6n   Name6t   �� 5%   
   $
��Left=�6   $��21��6+   $��498,128,0,0q�67   $	��Top=�6L   $��54��6d   $ 0.563,0.529&�6o   $
��Name��6�    50   
   �� 52      $	��230 �6   	 � RowDefinitions	 58   
   �� 5:      $
��Auto �6   �� 5<      �� 5=      $
��Auto �6   ��5A   
   �� 5B      
 �� ImageSource$
 /watermark.png.jpeg��6   5E      5F      