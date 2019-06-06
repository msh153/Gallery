using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
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

        public List<Image> Images = new List<Image>();
        public Image SelectedPhoto;
        public bool needAnimation;
        public int interval;
        public bool Check;
        private DispatcherTimer timer = new DispatcherTimer();
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (!needAnimation)
            {
                return;
            }
            buttonNext.Visibility = Visibility.Hidden;
            buttonPrevious.Visibility = Visibility.Hidden;
            if(!Check)
            timer.Tick += (s, ev) => buttonNext.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
             else timer.Tick += (s, ev) => buttonPrevious.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            timer.Interval = new TimeSpan(0, 0, interval);
            timer.Start();
        }

        public void Add(List<Image> images)
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
            if (!needAnimation)
            {
                myDoubleAnimationNext.From = 1;
                myDoubleAnimationNext.To = 1;
            }
            SelectedPhoto = Images[counterPhoto];
            
        }

        private void Button_Prev_Click(object sender, RoutedEventArgs e)
        {
                var counterPhoto = Images.IndexOf(SelectedPhoto);
                if (counterPhoto == 0)
                {
                    counterPhoto = Images.Count;
                }
            counterPhoto--;

            ViewedPhotoForSlideShow.Source = Images[counterPhoto].Source;
            if (!needAnimation)
            {
                myDoubleAnimationPrev.From = 1;
                myDoubleAnimationPrev.To = 1;
            }
                SelectedPhoto = Images[counterPhoto];
        }

        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Right)
            {
                Button_Next_Click(sender, e);
            }
            else if (e.Key == System.Windows.Input.Key.Left)
            {
                Button_Prev_Click(sender, e);
            }
            else if (e.Key == System.Windows.Input.Key.Space)
                timer.Stop();
            else if (e.Key == System.Windows.Input.Key.Enter)
                timer.Start();
        }
    }
}
