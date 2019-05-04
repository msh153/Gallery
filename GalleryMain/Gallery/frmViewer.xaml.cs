using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Gallery
{
    /// <summary>
    /// Interaction logic for frmViewer.xaml
    /// </summary>
    public partial class frmViewer : Window
    {


        public frmViewer()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        public IList<Image> Images = new List<Image>();
        public Image SelectedPhoto;
        public bool needAnimation;
        public int interval;
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (!needAnimation)
            {
                return;
            }
            buttonNext.Visibility = Visibility.Hidden;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += (s, ev) => buttonNext.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            timer.Interval = new TimeSpan(0, 0, interval);
            timer.Start();
        }

        public void Add(IList<Image> images)
        {
            Images = images;
        }
        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            ViewedPhotoForSlideShow.Source = SelectedPhoto.Source;
        }

        private void Button_Next_Click(object sender, RoutedEventArgs e)
        {
            var counterPhoto = Images.IndexOf(SelectedPhoto);
            counterPhoto++;
            if (counterPhoto == Images.Count)
            {
                counterPhoto = 0;
            }
            ViewedPhotoForSlideShow.Source = Images[counterPhoto].Source;
            SelectedPhoto = Images[counterPhoto];
            
        }
    }
}
