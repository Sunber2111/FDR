   M S B A M L   `   `   `  ����>  :FDR, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:FDR.ViewModelFDR.ViewModel  5      3clr-namespace:FDR.ResourceXAMLFDR.ResourceXAML  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089S OMaterialDesignThemes.Wpf, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null!    FDR.ViewModel.MainViewModel 
  MainVM$   FDR.ViewModel.SubjectViewModel 	 SubVM  ListViewItemStyle1  �� 
TargetType �� Property �� Value �� RelativeSource �� AncestorLevel �� AncestorType �� 
TargetType%  MaterialDesignThemes.Wpf.Ripple J� SnapsToDevicePixels   Feedback	 �� Property
 �� 	Converter=  7MaterialDesignThemes.Wpf.Converters.BrushRoundConverter   	HighValue   LowValue  ScrollBarTrackThumb �Name ��Name �� CornerRadius �� Triggers P� Property P� Value �� 
TargetName � RowDefinitions ]�Name ]� Thumb n�Name ]� IncreaseRepeatButton ��Name J� Opacity ]� DecreaseRepeatButton P� 
SourceName  ButtonSelectBrush  	DarkBrush �� Angle�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      FmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      )	viewmodelclr-namespace:FDR.ViewModel  5      (localclr-namespace:FDR.ResourceXAML  5      %L  &	        &	      &	 &     &	 Q    '��        5      6     5	      6!   �� 5      "  ��6'   .�5   
   ��  � ��
 ���� 6'   �� 5   
    � ��$ 0q�6,   �� 5   
    � �� 67   �� *HorizontalContentAlignment+ �� *FindAncestor+$ 1��" ���� 5   
    � �� 65   �� *VerticalContentAlignment+ �� *FindAncestor+$ 1��" ���� 5   
    � ��$ 0q�6$   �� 5   
    �@J�SnapsToDevicePixels . 60   �� 5   
    � �� 5      �� 5      " ��6"   .R�5      �� #��z��6   #��z��6I   
������ #}�z}�5   :   #��z��6h   ._�5      � .+�5        #��z��64   #��z��6h   |�.  #��z��5   J   #��z��6�   # z 5   8   #��z��6t    5   "   �� 5   &   	 � ��
 5    *     5!   .   
 �����
 ���� 6c   5#   '   5%      5&      5'      5)      5+      5,      �� 5.      "  n�5/   	   .�50   
   ��  � �� 51      �� 52      " n�6"   .R�53      � $
 Grid��6   .+�54      �� $��Stretch=�6$   $��Stretch=�55   !   $
��Auto��56   !   $
��Auto��57   !   
������ 58   !   �� 59      $ CornerScrollBarRectangle��6!   $ 5��5:      $��Stretch=�5;      $��Stretch=�5<      $
��Auto��5=      $
��Auto��5>      $��0,1,0,1q�5?      #��z��5@      5A       5B      P� 5C       �@�Tag$ 
Horizontal��5D   !   . �5E      �� $ CornerScrollBarRectangle��6%    � ��$
 Auto��5G   !   �� 5H      $ CornerScrollBarRectangle��6%    � ��$ 6��5J   !   5K      5M      5O      5P      �� 5R      "  ��6   .�5S   
   ��  �@��IsFlicksEnabled .  5T      �� 5U   
    � �� �#ADABAB5V      �� 5W   
    � ��
 ���� 5X      �� 5Y   
    � ��$ 7��5Z      �� 5[   
    � �� 5\      �� 5]      " ��6"   .R�5^      � $ GridRoot��6   $��7��5_      #��z��5`       5a      �� 5b      $��0.00001* �6,   .+�5d      ]� $ 
PART_Track��6    $��0��5e      ��. |�.   5h      n� 5i   "   $ Thumb��6(   #��z��5j   %   #���  5k   %    5m      �� 5n   "   $ PageUp��6/   $��ScrollBar.PageDownCommand��5o   -   $ 0Q�5p   -   |�.  5q   -    5s      �� 5t   "   $ PageDown��6/   $��ScrollBar.PageUpCommand��5u   -   $ 0Q�5v   -   |�.  5w   -   5y      5z       5{      P� 5|      $ Thumb��6"    �@J�IsMouseOver . . �5      �� # �  6%   $ Thumb��5�   !    � ��5�   !   5�      P� 5�      $ Thumb��6"    �@n�
IsDragging . . �5�      �� # �  6%   $ Thumb��5�   !    � ��5�   !   5�      P� 5�       � {� .  . �5�      �� $ Thumb��6%    � y�$ 	Collapsed=�5�   !   5�      P� 5�       �@��Orientation$ 
Horizontal=�5�   !   . �5�      �� $ GridRoot��6%    �@�LayoutTransform 5�   "   �� 5�   &   $	 -90Q�66   5�      �� 5�      $ 
PART_Track��6%    �@�LayoutTransform 5�   "   �� 5�   &   $	 -90Q�66   5�      �� 5�       � ��$
 Auto��5�   !   �� 5�       � ��$ 8��5�   !   �� 5�      $ Thumb��6%    �@�Tag$ 
Horizontal��5�   !   �� 5�      $ PageDown��6%    � ��$ ScrollBar.PageLeftCommand��5�   !   �� 5�      $ PageUp��6%    � ��$  ScrollBar.PageRightCommand��5�   !   5�      5�      5�      5�      5�      