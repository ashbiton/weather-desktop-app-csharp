   M S B A M L   `   `   `  ����=  9PL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLPL  5   	   -clr-namespace:PL.ConvertersPL.Converters  5   	       PL.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:PL     5   	   2
Convertersclr-namespace:PL.Converters     5   	   -   5        $��
WindowMain��5   	     � Title$  Weather App��5   	   $	��450��6   $	��800��6*    � 	Resources 5      /  )PL.Converters.ListSizeToFontSizeConverter   ListSizeToFontSizeConverter6  0PL.Converters.HeightOfWindowToChartSizeConverter & "HeightOfWindowToChartSizeConverter��%:   &	        &	        5   
   61     5   
   68   5      .��5      � -   5        $��MainGrid��5      ��5   
   �� 5       �� ImageSource$ Images\sky_107.bmp��6    j� Stretch$
 Fill=�6:    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��8* �6    � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��8* �6   .+�5   
   �� $��0��6   $��0��6$   
������ $��0��6F   ��5      �� 5       �� Color$ Black��6"    �� Opacity$	 0.2Q�60   5       >� 5!   
   -   5        $��ButtonsUserControl��5!      $��0��60   $��1��6=   
���   � J� Opacity$	 0.2Q�6�   $��0q�6�   ��6M   �� *MainWindowButtons+6�   >� 5"   
   -   5        $��userControl��5"   *   $��0,10,0,0q�6   $��1��6=   $��1��6J   $��0q�6z   ��6Z   �� *UserControl+6z   �� 5#   
   -   5        $��CitiesListView��5#      $��0q�5$      
���   �$	 0.2Q�6:   
�������$��1��6[   $��0��5%      ��5#   )   �� 	 �� ElementName$	 CitiesListView��
 �� Path$
 ActualHeight� �� 	Converter# [  ��5%   #   �� *Cities+ �� SelectedItem 6B   �� *City+��5'      �� 5)       �� 
TargetType" ��6   .�5*      ��  �� Property � �� �� Value 5+      �� 5,       �� 
TargetType" ��6.   .R�5-   "   �� 5.      50       �� Triggers 52      P� 53       P� Property �@��
IsSelected P� Value . . �54      ��  � ��
 �����6<   �� 55       � ��$ 2q�6@   �� 56       � ��$
 Bold"�6;   �� 57       � �� 69   �� $	 CitiesListView��$
 ActualHeight�# [ 58      P� 59       �@J�IsMouseOver . . �5:      ��  � �� 5;   "   �� 5<   &   .R�5=   *   �� $��	Underline{�64   #��z��6P   5>   '   5@      5A      5C      5E      5F      5G      