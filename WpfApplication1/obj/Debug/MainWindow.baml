   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	    WpfApplication1    WpfApplication1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6F   6sys&clr-namespace:System;assembly=mscorlib     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��800��6)      WindowBackgroundBrush#���   5   	    � 	Resources 5        ComboBoxTitle  ComboBoxItems �� Type � Offset � Color��%-  &	       &	      &	  �     ��5	   
   
Items:��63   �� 5   
   " ��6(   .s�5      ��Item #1��6"   ��5      Item #2��6"   ��5      Item #55��6#   5      �� 5   
   .��5      � $ 0Q�6   $
 Gray��6&   � 5      $ 1Q�6   $	 Red��6&   5      5      .��5      ]� $��10q�6   .+�5      �� $��10q�6   .+�5   
   �� #��[ 6   �� 5   
   -   5        #��[ 5      6@   �� 5   
   $��_Name:��6    �� Target 6!   ��  �� ElementName$ txtName���� 5   
   -   5        $��txtName��5      �� 5   
   $��_Mail:��6    6!   �� $ txtMail���� 5   
   -   5        $��txtMail��5      � 5   	   .+�5      �� $��Window title:  ��6$   �� 5       -   5        $��txtWindowTitle��5    "   $	��150��6m   ��68   �� *Title+ �� UpdateSourceTrigger$ Explicit=�6m   �� 5!      -   5        $��btnUpdateSource��5!   !   $	��5,0q�6V   $	��5,0q�6c   .��6q   *6t   5"      � 5#      $��0,10,0,0q�6   .+�5$      �� $��Window dimensions: ��6$   �� 5%      $��50��6X   ��6"   �� *Width+$ 	LostFocus=�6X   �� 5&      $	�� x ��6$   �� 5'      $��50��6_   ��6"   �� *Height+$ PropertyChanged=�6_   5(      5+      �� 5,   
   $��Right=�6   $��10,0,0,0q�6,   .+�5-      �� -   5        $��
btnAddUser��5-      .��6@   
Add user6J   �� 5.      -   5        $��btnChangeUser��5.      $	��0,5q�6F   .��6S   Change user6`   �� 5/      -   5        $��btnDeleteUser��5/      .��6F   Delete user6S   50      �� 51   
   -	   5        $��lbUsers��51       �� DisplayMemberPath$
 Name��6!   6<   52      53      