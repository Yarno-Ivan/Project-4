   M S B A M L   `   `   `  ����N  JProject4_Ivan_Yarno, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Project4_Ivan_YarnoProject4_Ivan_Yarno  5   	   '    !Project4_Ivan_Yarno.NavigatieMenu   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Project4_Ivan_Yarno     5   	     � Title$  NavigatieMenu��5   	   $	��450��6   $	��800��6,   .��5	      � ��5
   
   �� 5       �� ImageSource$ 
pizza2.png��6   64    � ColumnDefinitions 5   
   �� 5      $
��0.1* �6   �� 5      $
��0.2* �6   �� 5      �� 5      $
��0.2* �6   �� 5      �� 5      $
��0.2* �6   �� 5      �� 5      $
��0.2* �6   �� 5      $
��0.1* �6    � RowDefinitions 5   
   �� 5      $
��0.1* �6   �� 5      $
��0.3* �6   �� 5      �� 5      $
��0.3* �6   �� 5      �� 5      $
��0.3* �6   �� 5      $
��0.1* �6   .+�5!   
   �� -   5         ��Name$ BtBestellingen��5!      $��2��6)   $��2��69   $��Bestellingen��6F   $��25(�6]   6k   �� 5"   
   -   5        $ BtBezorging��5"      $��4��6&   $��2��66   $��	Bezorging��6C   $��25(�6W   6e   �� 5#   
   -   5        $ BtBeheerIngredienten��5#      $��6��6/   $��2��6?   $��25(�6L   .��5$      ��  �� TextAlignment$ Center=�6   Ingredienten�� 6<   	Beheren6P   5%      �� 5&   
   -   5        $ BtBeheerKlant��5&      $��2��6(   $��4��68   $��25(�6E   .��5'      �� $ Center=�6   Klant�� 65   
gegevens6J   5(      �� 5)   
   -   5        $ BtBeheerPersoneel��5)      $��4��6,   $��4��6<   $��25(�6I   .��5*      �� 	Personeel�� 6"   
gegevens67   5+      �� 5,   
   -   5        $ BtBeheerPizzas��5,      $��6��6)   $��4��69   $��25(�6F   .��5-      �� $ Center=�6   	Pizza's�� 67   	Beheren6K   5.      5/      50      