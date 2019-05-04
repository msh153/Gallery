using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.IO;
using System.Collections.ObjectModel;
using System.Drawing.Imaging;
using System.Windows.Media.Imaging;
using MessageBox = System.Windows.MessageBox;

namespace Gallery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {

        IList<Image> images = new List<Image>();
        private List<string> filter = new List<string>() { @"bmp", @"jpg", @"gif", @"png" };

        public MainWindow()
        {
            InitializeComponent();
        }
        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            FileInfo[] files;
            try
            {
                DirectoryInfo info = new DirectoryInfo(textBox.Text);
                files = info.GetFiles().OrderByDescending(p => p.LastWriteTime).ToArray();
            }
            catch
            {
                MessageBox.Show("Folder path is not correct");
                throw new FileNotFoundException();
            }
            foreach (var file in files)
            {
                if (filter.Exists(n => n == file.Name.Split('.').Last().ToLower()))
                {
                    try
                    {
                        var bi = new BitmapImage(new Uri(file.FullName))
                        {
                            CacheOption = BitmapCacheOption.OnLoad
                        };

                        var img = new System.Windows.Controls.Image
                        {
                            Source = bi,
                            Width = 200,
                            Height = 100
                        };
                        images.Add(img);
                    }
                    catch (Exception ex)
                    {
                        System.Windows.MessageBox.Show(ex.Message);
                    }
                }
            }
            listbox.ItemsSource = images;
        }

        private void OnPhotoClick(object sender, MouseButtonEventArgs e)
        {

            frmViewer pvWindow = new frmViewer
            {
                SelectedPhoto = (Image)listbox.SelectedItem,
                Images = images,
                needAnimation = false,
                 interval = 2
            };
            pvWindow.Show();
        }

        private void Open_Folder_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new System.Windows.Forms.FolderBrowserDialog();
            System.Windows.Forms.DialogResult result = dialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                textBox.Text = dialog.SelectedPath;
            }
        }

        private void StartSlideShowButton_Click(object sender, RoutedEventArgs e)
        {
            frmViewer pvWindow = new frmViewer
            {
                SelectedPhoto = (Image)listbox.SelectedItem,
                Images = images,
                needAnimation = true,
                interval = Convert.ToInt32(textBox_interval.Text)
        };
            pvWindow.Show();
        }
    }
}