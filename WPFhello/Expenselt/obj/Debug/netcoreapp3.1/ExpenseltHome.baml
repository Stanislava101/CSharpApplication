   M S B A M L   `   `   `  ����D  @Expenselt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Expenselt	Expenselt  5   	       Expenselt.ExpenseltHome   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Expenselt     5   	     � Title$  Expenselt - Home��5   	   $	��450��6"   $	��800��6/   .��5
      � .+�5   
   �� $��0��6   $��3��6    ��6-   ��  �� Path$ LastChecked��� 5   
   $��1��6   ��5      ��  �� RelativeSource ��  �� AncestorType" �$ MainCaptionText�5   ,   �� 5   
   $��35��6   $��534,39,-534,4q�6    �� Padding$ 5q�64   ���#4E87D4._�5      �� $��Center=�6   
�������$��0��6B   $��0��6R   .��6_   Names6f   5      �� 5   
   -   5        $��peopleListBox��5      $��0��6(   $��1��68   $��534,12,-534,90q�5   I   ��5   E   ��  �� " �$ ExpenseDataSource���5      �� 5      .R�5      �� ��6   �� $
 Name�5      5      �� 5(   
   $��
350,36,0,0q�6   $��86��6%   $
��Bold"�60    J� RenderTransformOrigin$ -0.525,2.238&�6B   $��55��6g   .��5)      �  � RowDefinitions 5*      �� 5,      �� 5.      .+�51      �� $��0��6   $��Това е бутон��6%   �� 52      $��1��6   $
��ОК��6%   �� 53      $��0,10,0,0q�6   .��6+   View61   54      56      �� 58   
   -   5        $
��Left=�58   W   $��27��6r   $��102,253,0,0q�6~   $��1��6�   $	��Top=�6�   $��94��6�   ��6   ��  �� ElementName$ peopleListBox��$ SelectedItem.Name�6�   �� 59   
   -   5        $��Greeting��59      $
��Left=�6$   $��52��6?   $��102,191,0,0q�6K   $��1��6`   $	��Top=�6m   $��94��6�   5<       � ColumnDefinitions 5I   
   �� 5J      $	��230 �6    5L   
   �� 5N      $
��Auto �6   �� 5P      �� 5Q      $
��Auto �6   ��5T   
   �� 5U      	 �� ImageSource$	 /watermark.png.jpeg��6   5X      5Y      