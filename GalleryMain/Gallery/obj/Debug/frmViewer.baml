   M S B A M L   `   `   `  ����B  >Gallery, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:GalleryGallery  5   	       Gallery.frmViewer   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Gallery     5   	   -   5          � Title$  Viewer��5   	   $	��444��6   $	��794��6%    � Icon$+ %wwalczyszyn-android-style-gallery.ico��6`   ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ Azure��6    � Offset$ 0Q�6)   � 5      $
 Aqua��6   $ 1Q�6(   5      .��5      � .+�5   
   �� -   5         ��Name$ ViewedPhotoForSlideShow��5      $
��Auto��61   $��41,10,38,62q�6?   �� 5   
   -   5         ��Name$ 
buttonNext��5      $
��Next��6%   $��Right=�64   $��	0,0,75,10q�6P   $��Bottom=�6c   $��75��6~    � Triggers 5      :� 5      	 :� RoutedEvent$	 Button.Click��6   .[�5      �� .��5      �� .��5      W� -   5        
 g�Name$
 myDoubleAnimationNext��5   .    �� 
TargetName$ ViewedPhotoForSlideShow��5       �� TargetProperty$ Opacity�5       W� From$	 0.0X�5      	 W� To$	 1.0X�6    g� Duration$ 0:0:2D�6!    g� AutoReverse .  5      5      5      5      5!      �� 5"   
   -   5        $ buttonPrevious��5"      $��Previous��6)   $
��Left=�6<   $��
116,0,0,10q�6W   $��Bottom=�6k   $��75��6�    5#      :� 5%      $	 Button.Click��6   .[�5&      �� .��5'      �� .��5(      W� -   5        $
 myDoubleAnimationPrev��5)   !   $ ViewedPhotoForSlideShow��5*      $ Opacity�5+      $	 0.0X�5,      $	 1.0X�6   $ 0:0:2D�6!    .  5-      5.      5/      50      53      55      56      