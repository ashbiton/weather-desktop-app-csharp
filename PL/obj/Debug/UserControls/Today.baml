   M S B A M L   `   `   `  ����=  9PL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:PL.UserControlsPL.UserControls  5      -clr-namespace:PL.ConvertersPL.Converters  5      | xSystem.Windows.Controls.DataVisualization.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35�{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit2System.Windows.Controls.DataVisualization.Charting 5      �rclr-namespace:System.Windows.Controls.DataVisualization;assembly=System.Windows.Controls.DataVisualization.Toolkit)System.Windows.Controls.DataVisualization 5	      ��clr-namespace:System.Windows.Controls.DataVisualization.Charting.Primitives;assembly=System.Windows.Controls.DataVisualization.Toolkit=System.Windows.Controls.DataVisualization.Charting.Primitives 5
          PL.UserControls.Today   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:PL.UserControls     5      6localConverterclr-namespace:PL.Converters     5      �charting{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit     5      �datavisrclr-namespace:System.Windows.Controls.DataVisualization;assembly=System.Windows.Controls.DataVisualization.Toolkit     5	      �chartingprimitives�clr-namespace:System.Windows.Controls.DataVisualization.Charting.Primitives;assembly=System.Windows.Controls.DataVisualization.Toolkit     5
        � 	Resources  5      "   PL.Converters.ImageConverter   imageConverter*  $PL.Converters.SunriseSunsetConverter  SunriseSunsetConverter4  .PL.Converters.ContainerSizeToTextSizeConverter $  ContainerSizeToTextSizeConverter(  "PL.Converters.WindowSizeToTempSize  WindowSizeToTempSize/  )PL.Converters.WindowSizeToDescriptionSize  WindowSizeToDescriptionSize-  'PL.Converters.HeightToFontSizeConverter  HeightToFontSizeConverter6  0PL.Converters.HeightOfWindowToChartSizeConverter & "HeightOfWindowToChartSizeConverter2  ,PL.Converters.UCSizeToDataPointSizeConverter " UCSizeToDataPointSizeConverter & "PerformanceChartMajorTickMarkStyle �� 
TargetType �� Property �� Value F� Color F� 	Direction F� ShadowDepth F� Opacity �� Triggers	 �� Binding
 �� RelativeSource �� Path �� 	Converter 	 ChartMajorTickMarkStyle��%�  &	        &	      &	 &     &	 9     &	 L     &	 _     &	 r     &	 �     &	 �     '�� �     7  &		 �      5   
   6(     5   
   60     5   
   6:     5   
   6.     5   
   65     5   
   63     5   
   6<     5   
   68   �� 5   
   " ��6<   .�5      ��  � y�$ 	Collapsed=�6+   5      �� 5   
   " ��6   .�5      ��  � ��$ 22(�6)   �� 5       � ��$ Expanded&�6,   �� 5       � ��
 �����6+   �� 5        � ��$ Gisha)�6+   �� 5!       �@J�BitmapEffect 5"      F� 5#      $ Black��6-   $	 330Q�6;   $ 4Q�6K   $	 0.5Q�6[   5%       5&      �� 5'      	 6   �� 
 �� *Self+$ Width�.a�5(      ��  � �� 61   �� 
 �� *Self+$ Width�8   5)      5+      �� 5,   
   " ��61   .�5-      ��  � y�$ 	Collapsed=�6+   5.      5/      .��51      � -   5        $��mainGridToday��51       � RowDefinitions 52   
   �� 53      $
��1.5* �6   �� 54      $��2* �6   .+�56   
   � -   5        $��weatherDataGrid��56      $��0��6M    � DataContext 6&   �� *CurrentWeather+ 57      �� 58      $��1* �6    �� 59      $��3* �6     � ColumnDefinitions 5;      �� 5<      $��2* �6#   �� 5=      $
��1.3* �6#   �� 5>      $
��1.7* �6#   �� 5?      $��2* �6#   .+�5A      � -   5        $��TempDataGrid��5A      $��1��6'   $��1��64    5B      �� 5C      $
��1.5* �6$   �� 5D      $��1* �6$   �� 5E      $��2* �6$   �� 5F      $
��1.5* �6$   .+�5H      �� -   5        $��tempTextBlock��5H   -   $��5,0,0,0q�6   $��0��6~    �� TextAlignment$
 Left=�6�   ��6B   �� $ 	main.temp� �� StringFormat$ {0}ºC����6�   ��  �� ElementName$ mainGridToday��$ ActualHeight�# [ �� 5I      $��5,0,0,0q�6   $��1��6Z   $
 Left=�6g   ��6-   �� $ weather[0].description���6|   �� $ mainGridToday��$ ActualHeight�# [ �� 5J      -   5        $��weatherIcon��5J      $��2��6}   $
��Left=�6�   $	��Top=�6�   ��6+   �� $ weather[0].icon�# [  ��6�   �� $ mainGridToday��$ ActualWidth�# [ 5K      � 5L      -   5        $��AnotherDataGrid��5L      $��1��6*   $��2��67    5M      �� 5N      $��1* �6$   �� 5O      $��1* �6$   �� 5P      $��1* �6$   �� 5Q      $��1* �6$   �� 5R      $��2* �6$    5T      �� 5U      $��2* �6'   �� 5V      $
��1.6* �6'   .+�5X      �� $��	Humidity:��6   $��0��6-   $��0��6:   ��6J   �� $ mainGridToday��$ ActualHeight�# [ �� 5Y      $��0��6U   $��1��6b   $
 Left=�6r   ��6   �� $ main.humidity�$
 {0}%����6�   �� $ mainGridToday��$ ActualHeight�# [ �� 5Z      $��Wind Speed:��6   $��1��6/   $��0��6<   ��6L   �� $ mainGridToday��$ ActualHeight�# [ �� 5[      $��1��6V   $��1��6c   $
 Left=�6s   ��6   �� $ 
wind.speed�$ {0} km/h����6�   �� $ mainGridToday��$ ActualHeight�# [ �� 5\      $��Sunrise:��6   $��2��6,   $��0��69   ��6I   �� $ mainGridToday��$ ActualHeight�# [ �� 5]      $��2��6q   $��1��6~   $
 Left=�6�   ��6   �� $ sys.sunrise�# [ ��6�   �� $ mainGridToday��$ ActualHeight�# [ �� 5^      $��Sunset:��6   $��3��6+   $��0��68   ��6H   �� $ mainGridToday��$ ActualHeight�# [ �� 5_      $��3��6p   $��1��6}   $
 Left=�6�   ��6   �� $ 
sys.sunset�# [ ��6�   �� $ mainGridToday��$ ActualHeight�# [ 5`      5a      >	  8System.Windows.Controls.DataVisualization.Charting.Chart	  5c   
   -   5        $��	tempChart��5c      
�������$��1��6�   
������ 
������ $��0q�6%   6*   �� *NextHoursInfo+��6P   �� $ 	tempChart��$ ActualHeight�# [  	  Axes 5e      C
  =System.Windows.Controls.DataVisualization.Charting.LinearAxis
  =  7System.Windows.Controls.DataVisualization.Charting.Axis   Orientation$ Y=�6&   $y�Hidden=�66   D  >System.Windows.Controls.DataVisualization.Charting.DisplayAxis   ShowGridLines .  D  >System.Windows.Controls.DataVisualization.Charting.NumericAxis   Maximum�  �System.Windows.Controls.DataVisualization.Charting.NullableConverter`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]$ 46 6`      Minimum$ 0 6m   E  ?System.Windows.Controls.DataVisualization.Charting.CategoryAxis  5f      $ X=�6(      MajorTickMarkStyle# [ 68    	  LegendStyle 5i      �� 5j      6  0System.Windows.Controls.DataVisualization.Legend"  6   .�5k      ��  � ��$ 0��6.   �� 5l       � ��$ 0��6/   5m       	  PlotAreaStyle 5p      �� 5q      " �6   .�5r      ��  � ��
 ���� 63   5s       	  Series 5v      C  =System.Windows.Controls.DataVisualization.Charting.LineSeries  
������ $
��Bold"�5w   k   
�������H  BSystem.Windows.Controls.DataVisualization.Charting.DataPointSeries   IndependentValueBinding 5v   ?   �� $	 Key�   DependentValueBinding 5w   &   �� $ Value�   ItemsSource 6S   ��    DataPointStyle 5x      �� 5y      F  @System.Windows.Controls.DataVisualization.Charting.LineDataPoint"  6    .�5z      ��  � �� 67   �� $ mainGridToday��$ ActualHeight�# [ �� 5{       � ��
 �����6;   �� 5|       �@J�BitmapEffect 5}   "   F� 5~   &   $
 Gray��6=   $	 330Q�6J   $ 4Q�6Z   $	 0.5Q�6j   5�      �� 5�       � ��$ 0q�6@   �� 5�       � �� 5�   "   �� 5�   &     �� 
TargetType"   66   .R�5�   *   � .+�5�   .   A� #��z��66   �� 5�   .   .+�5�   2   �� $��	0,-15,0,0q�6n   ��6<   �� *Value+$ {0}º��6n   5�   /   5�   +   5�   '   5�      5�      5�      ��5�      �� 5�      "  	 6"   .R�5�      �� #��z��6   ! �� Padding#! z��6G   ._�5�      �  5�      �� 5�   "   $
��Auto �60   �� 5�   "   $��* �60   .+�5�      5  /System.Windows.Controls.DataVisualization.Title  " 	  Title#��z" 6,   # 	  
TitleStyle#��z# 6N   M  GSystem.Windows.Controls.DataVisualization.Charting.Primitives.EdgePanel  5�      $��	ChartArea��6;   $ 	  ChartAreaStyle#��z$ 6L   $��1��6u   $��	0,15,0,15q�6�   .+�5�   "   � % K� ZIndex$% -1��6'   #��z 69   �� 5�   "   $% 10��6)   
������ $��0q�6U   5�      5�      5�      5�      5�      5�      5�      