   M S B A M L   `   `   `  ���� B  >Gallery, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:GalleryGallery      Gallery.frmViewer   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:Gallery     -     � Title$  Viewer��$	��444��$	��794�� � Icon$+ %wwalczyszyn-android-style-gallery.ico������  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Azure�� � Offset$ 0Q�� $
 Aqua��$ 1Q�.��� .+��� -    ��Name$ ViewedPhotoForSlideShow��$
��Auto��$��41,10,38,62q��� -    ��Name$ 
buttonNext��$
��Next��$��Right=�$��	0,0,75,10q�$��Bottom=�$��75�� � Triggers :� 	 :� RoutedEvent$	 Button.Click��.[��� .���� .��W� -   
 g�Name$
 myDoubleAnimationNext�� �� 
TargetName$ ViewedPhotoForSlideShow�� �� TargetProperty$ Opacity� W� From$	 0.0X�	 W� To$	 1.0X� g� Duration$ 0:0:2D� g� AutoReverse .  �� -   $ buttonPrevious��$��Previous��$
��Left=�$��
116,0,0,10q�$��Bottom=�$��75�� :� $	 Button.Click��.[��� .���� .��W� -   $
 myDoubleAnimationPrev��$ ViewedPhotoForSlideShow��$ Opacity�$	 0.0X�$	 1.0X�$ 0:0:2D� .  