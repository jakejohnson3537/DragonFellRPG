   M S B A M L   `   `   `  ����@  <RPGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:RPGUIRPGUI  5   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	       RPGUI.MainWindow   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   e aMahApps.Metro.IconPacks.Modern, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   Fmc;http://schemas.openxmlformats.org/markup-compatibility/2006   5   	   !localclr-namespace:RPGUI   5   	   Gmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro   5   	      MaterialDesignPaper#���   5	   	     MaterialDesignBody#���  5
   	     � Title$  
MainWindow��5   	     MahApps.Brushes.Accent(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �  6   $	��768��6Q   $
��1024��6^    � WindowStartupLocation$ CenterScreen=�6k    � 	Resources 5        BooleanToVisibility��%   &	       �� 5   
   6'   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $	��225 �6    � ColumnDefinitions 5   
   �� 5      $	��250 �6   �� 5      $��* �6   .+�5    
   �� $��0��6   $��0��6   $��2��6-   $
��Menu��6A   ���#461e526P   � 5#   
   $��1��6   $��0��6   ���#dd517f 5$      �� 5%      $
��Auto �6    �� 5&      $
��Auto �6    �� 5'      $
��Auto �6    �� 5(      $
��Auto �6    �� 5)      $
��Auto �6    �� 5*      $
��Auto �6    �� 5+      $
��Auto �6     5.      �� 5/      $
��Auto �6#   �� 50      $
��Auto �6#   .+�53      �� $��0��6   $��0��6!   $��Name:��61   $��Copperplate Gothic Light)�6A   �� 54      $��0��6   $��1��6!   $��Copperplate Gothic Light)�61   ��6W   �� *CurrentPlayer.Name+�� 55      $��1��6   $��0��6!   $��Class:��61   $��Copperplate Gothic Light)�6B   �� 56      $��1��6   $��1��6!   $��Copperplate Gothic Light)�61   ��6W   �� *CurrentPlayer.CharacterClass+�� 57      $��2��6   $��0��6!   $��Hit points:��61   $��Copperplate Gothic Light)�6G   �� 58      $��2��6   $��1��6!   $��Copperplate Gothic Light)�61   ��6W   �� * CurrentPlayer.CurrentHitPoints+�� 59      $��3��6   $��0��6!   $��Gold:��61   $��Copperplate Gothic Light)�6A   �� 5:      $��3��6   $��1��6!   $��Copperplate Gothic Light)�61   ��6W   �� *CurrentPlayer.Gold+�� 5;      $��4��6   $��0��6!   $	��XP:��61   $��Copperplate Gothic Light)�6?   �� 5<      $��4��6   $��1��6!   $��Copperplate Gothic Light)�61   ��6W   �� * CurrentPlayer.ExperiencePoints+�� 5=      $��5��6   $��0��6!   $��Level:��61   $��Copperplate Gothic Light)�6B   �� 5>      $��5��6   $��1��6!   $��Copperplate Gothic Light)�61   ��6W   �� *CurrentPlayer.Level+5?      � 5B   
   $��1��6   $��1��6   ���#556dc8 5D      �� 5E      $��* �6    �� 5F      $��* �6     5I      �� 5J      $��3* �6#   �� 5K      $��2* �6#   .+�5O      �� $��0��6   $��0��6"   $��2��5P      ���#7998ee$��1q�5R      ._�5U      �� -   5         ��Name$ GameMessages��5U      ���#556dc8
���   �$��18(�5X        MaterialDesignRichTextBox#���  5Y      " �� VerticalScrollBarVisibility$
 Auto=�5Z      $��Copperplate Gothic Light)�6A    5[       �� 
TargetType	 �� Property
 �� Value��%X   'J�       �� 5\      " J�6    .�5]      �� 	 �@��Margin$
 0q�67   5^      5_      5`      5c      �� 5f      $��0��6   $��1��6"   ���#7998ee$��1q�5h      ._�5j      � $��3q�6    5k      �� 5l      $
��Auto �6(   �� 5m      $��* �6(   �� 5n      $
��Auto �6(   .+�5q      �� $��0��6    $��Center=�5r       $��Copperplate Gothic Light)�5s   F   ��6    �� *CurrentLocation.Name+6F   �� 5u      $��1��6   $��Center=�5v      $��Center=�5w      $	��125��5x      $	��125��5y      ��5z      �� *CurrentLocation.ImageName+�� 5|      $��2��6    $��Center=�5}       $
��Wrap=�5       $��Copperplate Gothic Light)�64   ��5~       �� *CurrentLocation.Description+5   4   5�      5�      �� 5�      $��1��6   $��1��6"   ���#7998ee$��1q�5�      ._�5�      �  5�      �� 5�      $
��Auto �6(   �� 5�      $��* �6(   �� 5�      $
��Auto �6(   .+�5�      �� $��0��6    $��Center=�5�       $
��Auto��5�       $��Copperplate Gothic Light)�5�   E   ��6    �� *CurrentMonster.Name+6E   �� 5�      $��1��6   $��Center=�5�      $��Center=�5�      $	��125��5�      $	��125��5�      ��5�      �� *CurrentMonster.ImageName+�� 5�      $��2��6!   $��Center=�5�   !    �� Orientation$ 
Horizontal=�5�   !   y�5�   !   �� *
HasMonster+ �� 	Converter# [ .+�5�      �� $��Copperplate Gothic Light)�6$   Current Hit Points:6_   �� 5�      $��Copperplate Gothic Light)�6U   ��6$   �� *!CurrentMonster.CurrentHitPoints+6U   5�      5�      5�      5�      � 5�   
   $��2��6   $��0��6   ���#461e52.+�5�      ��  J� IsManipulationEnabled$ False��6   ���#461e52.@�5�      �� $��	Inventory��6   $��Copperplate Gothic Light)�6-   .��5�      &   System.Windows.Controls.DataGrid    MaterialDesignDataGrid#���  5�       % !MahApps.Styles.DataGridCell.Azure   	CellStyle# �  5�          
IsReadOnly$
 True��5�      $��3q�5�         AutoGenerateColumns$ False��5�         HeadersVisibility$ Column=�5�      ��5�      �� * CurrentPlayer.GroupedInventory+   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Description��61      
IsReadOnly$
 True��5�   1      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5�   1   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5�   1   �� *	Item.Name+5�   1     5�      $	 Qty��61   $
 True��5�   1   $
 Auto 5�   1    5�   1   �� *
Quantity+  5�      $ Price��61   $
 True��5�   1   $
 Auto 5�   1    5�   1   �� *
Item.Price+5�   1   5�      5�      �� 5�      $��Quests��6   $��Copperplate Gothic Light)�6*   .��5�        $ False��5�      $ Column=�5�      ��5�      �� *CurrentPlayer.Quests+ 5�        5�      $
 Name��61   $ * 5�   1    5�   1   �� *PlayerQuest.Name+5�   1     5�      $ Done?��61   $
 Auto 5�   1    5�   1   �� *IsCompleted+5�   1   5�      5�      5�      5�      � 5�   
   $��2��6   $��1��6   ���#dd517f 5�      �� 5�      $��* �6     5�      �� 5�      $��* �6#   �� 5�      $	��300 �6#   .+�5�      � $��0��6   $��0��6    $��Center=�5�      $��Center=�5�      y�5�      �� *
HasMonster+# [  5�      �� 5�      $
��Auto �6$   �� 5�      $
��Auto �6$    5�      �� 5�      $	��150 �6'   �� 5�      $��10 �6'   �� 5�      $��50 �6'   .+�5�      �� $��	0 -80 0 0q�6   $��30��6+   $��Weapons��67   $��Center=�6I   $��Copperplate Gothic Light)�6f   $��16(�6�   $
��Bold"�6�   6�   �� 5�      $��0��6   $��0��6(    �� DisplayMemberPath$
 Name��5�       �� SelectedValuePath$ ID��5�      ��5�      �� *CurrentPlayer.Weapons+ �� SelectedItem 5�      �� *CurrentWeapon+5�      �� 5�      -   5        $��0��5�      $��2��6&   $	��Use��5      5     5     � 5     $��0��6   $��1��6     5	     �� 5
     $��* �6$   �� 5     $��* �6$   �� 5     $��* �6$    5     �� 5     $��* �6'   �� 5     $��* �6'   �� 5     $��* �6'   .+�5     �� -   5        $��0��5     $��1��6&   $��25��5     $��65��6%   $��10q�60    1 -MahApps.Styles.Button.Dialogs.AccentHighlight#���  5     $��North��5     y�5     �� *HasLocationToNorth+# [ 5     �� 5     -   5        $��1��5     $��0��6&   $��25��5     $��65��6%   $��10q�60   #���  5     $
��West��5      y�5     �� *HasLocationToWest+# [ 5      �� 5!     -   5        $��1��5!     $��1��6&   $��25��5"     $��60��6%    % !MahApps.Styles.Button.MetroSquare#���  5#     $��Trade��5&     $��Center=�6)   y�5%     �� *	HasTrader+# [ 5&  )   �� 5'     -   5        $��1��5'     $��2��6&   $��25��5(     $��65��6%   $��10q�60   #���  5)     $
��East��5,     y�5+     �� *HasLocationToEast+# [ 5,     �� 5-     -   5        $��2��5-     $��1��6&   $��25��5.     $��65��6%   $��10q�60   #���  5/     $��South��52     y�51     �� *HasLocationToSouth+# [ 52     54     56     58     59     