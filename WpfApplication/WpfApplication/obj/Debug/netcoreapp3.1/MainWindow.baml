   M S B A M L   `   `   `  ����I  EWpfApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfApplicationWpfApplication  5   	       WpfApplication.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WpfApplication     5   	     � Title$   Student information system��5   	   $	��680��6,   $	��825��69   .��5	      �� -   5        $��PersonalData��5	      $��Personal Data��6#   $��10,2,0,2q�6:   $��2q�6L   $	��660��6X   .��5
   
   � -   5        $��MainGrid��5
       � ShowGridLines$
 True��6   $��
100,0,-6,0q�64   .+�5      �� $��	330,0,0,0q�6   .+�5      �� -   5        $��lblfirstName��5      $��
First Name��6,   $��1q�6A   $��1q�6L   $
��Left=�6X   �� 5      -   5        $��tboxfirstName��5      $��[Enter Name Here]��6/   $��1q�6H   $��1q�6S   $	��350��6_   $��Right=�6k   �� 5      -   5        $��lbllastName��5      $��	Last Name��6+   $��1q�6?   $��1q�6J   $
��Left=�6V   �� 5      -   5        $��tboxlastName��5      $��[Enter last name Here]��6.   $��1q�6L   $��1q�6W   $	��350��6c   $��Right=�6o   �� 5      -   5        $��
lblsirName��5      $��SirName��6*   $��1q�6<   $��1q�6G   $
��Left=�6S   �� 5      -   5        $��tboxsirName��5      $��[Enter sirname Here]��6-   $��1q�6I   $��1q�6T   $	��350��6`   $��Right=�6l   �� 5      -	   5        $��
lblfaculty��5      $��Faculty��6*   $��1q�6<   $��1q�6G   $
��Left=�6S   �� 5      -
   5        $��tboxfaculty��5      $��Faculty��6-   $��1q�6<   $��1q�6G   $	��350��6S   $��Right=�6_   �� 5      -   5        $��lblspecialty��5      $��	Specialty��6,   $��1q�6@   $��1q�6K   $
��Left=�6W   �� 5      -   5        $��tboxspecialty��5      $��	Specialty��6/   $��1q�6@   $��1q�6K   $	��350��6W   $��Right=�6c   �� 5      -   5        $��lblOKS��5      $	��OKS��6&   $��1q�64   $��1q�6?   $
��Left=�6K   �� 5      -   5        $��tboxOKS��5      $	��OKS��6)   $��1q�64   $��1q�6?   $	��350��6K   $��Right=�6W   �� 5      -   5        $��	lblstatus��5      $��Status��6)   $��1q�6:   $��1q�6E   $
��Left=�6Q   �� 5      -   5        $��
tboxstatus��5      $��Status��6,   $��1q�6:   $��1q�6E   $	��350��6Q   $��Right=�6]   �� 5      -   5        $��
lblFNumber��5      $��FNumber��6*   $��1q�6<   $��1q�6G   $
��Left=�6S   �� 5      -   5        $��tboxFNumber��5      $��FNumber��6-   $��1q�6<   $��1q�6G   $	��350��6S   $��Right=�6_   �� 5      -   5        $��	lblCourse��5      $��Course��6)   $��1q�6:   $��1q�6E   $
��Left=�6Q   �� 5       -   5        $��
tboxCourse��5       $��Course��6,   $��1q�6:   $��1q�6E   $	��350��6Q   $��Right=�6]   �� 5#      -   5        $��lblflow��5#      $
��Flow��6'   $��1q�66   $��1q�6A   $
��Left=�6M   �� 5$      -   5        $��tboxflow��5$      $
��Flow��6*   $��1q�66   $��1q�6A   $	��350��6M   $��Right=�6Y   �� 5%      -   5        $��lblgroup��5%      $��Group��6(   $��1q�68   $��1q�6C   $
��Left=�6O   �� 5&      -   5        $��	tboxgroup��5&      $��Group��6+   $��1q�68   $��1q�6C   $��Right=�6O   $	��350��6k   �� 5(      -   5         ��Name$ Button��5(      $	��100��6)   $��20��65   $��Right=�6V   .��6r   Clear5*      �� 5,      -   5        $ 
btnDisable��5,      $	��100��6-   $��20��69   $��Right=�6\   .��6x   	Disable5.      �� 5/      -   5        $ 	btnEnable��5/      $��Center=�6,   $��Right=�6G   $	��100��6c   $��20��6o   $��1q�6{   $��1q�6�   .��6�   Enable51      �� 52      -   5        $ 
btnDisplay��52      $��Center=�6-   $��Right=�6H   $	��100��6d   $��20��6p   $��1q�6|   $��1q�6�   .��6�   	Display54      �� 55      -   5        $ btnText��55      $��Right=�6+   $	��100��6G   $��20��6S   $��0q�6_   $��0q�6j   .��6�   Text57      58      �� 59      $��49,54,422,351q�6   $
��Fill=�6+   $��./profile-pic.png��6:    J� RenderTransformOrigin$ 0.5,0.5&�6U   z�5:      V� 5;      .~�5<      �� �� 5=      �� 5>       �� Angle$ -0.148Q�6*   T� 5?      5@      5B      5D      5F      5G      