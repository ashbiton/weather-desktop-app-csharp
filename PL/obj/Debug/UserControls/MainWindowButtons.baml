   M S B A M L   `   `   `  ����=  9PL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:PL.UserControlsPL.UserControls  5      -clr-namespace:PL.ConvertersPL.Converters  5      '    !PL.UserControls.MainWindowButtons   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:PL.UserControls     5      6localConverterclr-namespace:PL.Converters     5        � 	Resources  5
      1  +PL.Converters.DoubleToOneFPCelsiusConverter   TempCorrectFormConverter6  0PL.Converters.HeightOfWindowToChartSizeConverter & "HeightOfWindowToChartSizeConverter-  'PL.Converters.HeightToFontSizeConverter  ConverterHeight8  2PL.Converters.HeightOfButtonsUCToFontSizeConverter ( $HeightOfButtonsUCToFontSizeConverter �� 
TargetType �� Property �� Value F� Color F� 	Direction F� ShadowDepth F� Opacity �� 
TargetType	 �� Triggers
 P� Property P� Value �� ElementName �� Path �� 	Converter��%�  &	        &	      &	 &     &	 9     '�� L     '	� �     7    5   
   67     5   
   6<     5   
   63     5   
   6>   �� 5   
   " ��6   .�5      ��  �@J�BitmapEffect 5      F� 5      $ Black��6-   $	 330Q�6;   $ 4Q�6K   $	 0.5Q�5   -   5      5      �� 5   
   " 	�6   .�5      ��  � ��
 ���� 6+   �� 5       � ��
 �����6+   �� 5       � ��
 ���� 6,   �� 5       � ��$ Center=�6;   �� 5       � ��$ Center=�69   �� 5       � �� 5      �� 5      " 	�6&   .R�5       �� #��z��6!   #��z��5!   !   #��z��5"   !   ._�5#      �� #��z��5$   !   #��z��5%   !   5&      5'      5)      	 5*      P� 5+      
 �@J�IsMouseOver . . �5,      ��  � �� 5-      �� 5.      .R�50   "   �� $��	Underline{�6,   #��z��6H   51      53      54      P� 55      
 �@d�	IsChecked$
 trueY�6/   . �56      ��  � �� 57      �� 58      .R�59   "   �� $
��Bold"�6,   #��z��6>   ��5:   ,   �� $ MainWindowButtonsGrid��$ ActualHeight�8   5<      5>      5?      5A      5B      .��5C      � -   5        $��MainWindowButtonsGrid��5C       � ColumnDefinitions 5D   
   �� 5E      $��4* �6   �� 5F      $��4* �6   �� 5G      $��4* �6   .+�5I   
   	� -   5        $��todayButton��5I      $��TODAY��6)   $��0��69   ��6I   �� $ todayButton��$ ActualHeight�# [ ��6�   �� *TodayCommand+	� 5J   
   -   5        $��forcastButton��5J      $��5 DAYS��6+   $��1��6<   ��6L   �� $ todayButton��$ ActualHeight�# [ ��6�   �� *ForecastCommand+	� 5K   
   -   5        $��	mapButton��5K      $��VIEW MAP��6'   $��2��6:   ��6J   �� $ todayButton��$ ActualHeight�# [ ��6�   �� *
MapCommand+5L      5M      