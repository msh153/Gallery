   M S B A M L   `   `   `  ���� M  ISystem, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089M3clr-namespace:System.ComponentModel;assembly=SystemSystem.ComponentModel  B >Gallery, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:GalleryGallery    Gallery.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Z VWPFToolkit.Extended, Version=1.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4UwpfxJhttp://schemas.microsoft.com/winfx/2006/xaml/presentation/toolkit/extended  <cm3clr-namespace:System.ComponentModel;assembly=System  !localclr-namespace:Gallery  -     �Name$  Gallery�� � Title$ Gallery��$��502.723��$��703.362�� � Icon$+ %wwalczyszyn-android-style-gallery.ico������  �� EndPoint$	 0,1&� �� 
StartPoint$	 0,0&�.���  � Color$ Azure�� � Offset$ 0Q�� $
 Aqua��$ 1Q�.��� $��28,0,2,8q� � ColumnDefinitions �� $��3* ��� $	��92* � � RowDefinitions �� $
��133* ��� $
��331* �	 � ContextMenu	 �� .@�m� -   $��
Remove all��.+��� -   $��ComboBoxShow��$��26��$	��Top=�$��85.519,9,408,0q�
 �� SelectedIndex$
 0��$��1��.@��� -   $
��Name��Name�� -   $��Create��Create�� -   $��LastWriteTime��Last write time�� -   $��Lenght��Lenght�� -   $��ComboBoxSearch��$��21��$	��Top=�$��134.519,73,411,0q�$
 0��$��1��.@��� -	   $	��day��Day�� -
   $��month��Month�� -   $
��year��Year�� -    ��Name$ 
LoadButton��$
��Load��$
��Left=�$��523.519,42,0,0q�$	��Top=�$��54��$��26��$��1���� $��1��$��19.519,101,53,56q�$��2��.���� -    ��Name$ listbox�� �� SelectionMode$ Extended=�$ �� IsSynchronizedWithCurrentItem$
 TrueY�$��Disabled=�  �� IsTextSearchCaseSensitive . $��	10,10,8,4q� J� 	AllowDrop . ���� *images+���� .R��  K� IsItemsHost . �� -    ��Name$ textBox��$
��Left=�$��20��$��
-14,46,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��460��$R��LC:\Users\misha\Source\Repos\coursework2\GalleryMain\Gallery\bin\Debug\images��$��2���� -   $ LoadButton_Folder��$��Open Folder��$
��Left=�$��429.519,42,0,0q�$	��Top=�$��75��$��26��$��1���� -   $ StartSlideShowButton��$��Start Slide Show��$
��Left=�$��324.519,71,0,0q�$	��Top=�$	��100��$��26��$��1���� -   $ textBox_interval��$
��Left=�$��21��$��561.519,73,0,0q�$
 Wrap=�$��2��$	��Top=�$��29��$��1���� -    ��Name$ label��$��Image change interval��$
��Left=�$��429.519,71,0,0q�$	��Top=�$��30��$	��127��$��1��� -   $��pbInterminate��$y�Hidden=� � Minimum$ 0Q� � Maximum$	 100Q� � IsIndeterminate . $��0,282,29,20q�$��1��$��2���� -   $ button_create��$��Create��$
��Left=�$��
-24,42,0,0q�$	��Top=�$��54��$��26��$��1��$��2���� -   $ 	labelLoad��$��LoadBy��$
��Left=�$��10,9,0,0q�$	��Top=�$��54��$��26��$��2���� -    ��Name$ checkBoxDescending��$��
Descending��$
��Left=�$��242.519,15,0,0q�$	��Top=�$��15��$��82��$��1���� -   $ 
label_date��$
��Left=�$��	10,0,0,24q�$��Bottom=�$��27��$��98��$��1��$��2���� -   $ buttonSearch��$��Search��$
��Left=�$��254.519,71,0,0q�$	��Top=�$��54��$��26��$��1���� -   $ textBoxSearch��
�������$��Enter value��$
��Left=�$��20��$��40.519,73,0,0q�$
 Wrap=�$	��Top=�$��84��$��1���� -   $ button_update��$y�Hidden=�$��Update��$
��Left=�$��
-24,97,0,0q�$	��Top=�$��54��$��26��$��1��$��2���� -   $ button_back��$y�Hidden=�$
��Back��$
��Left=�$��	-24,0,0,0q�$	��Top=�$��54��$��26��$��1��$��2���� -   $ 	AddButton��$	��Add��$
��Left=�$��523.519,9,0,0q�$	��Top=�$��54��$��25��$��1���� -   $ SortDate��$��Sort by
 date��$
��Left=�$��-24,157,0,0q�$��1��$	��Top=�$��54��$��34��$��2��