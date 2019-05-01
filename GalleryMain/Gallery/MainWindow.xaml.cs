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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.IO;
using System.Collections.ObjectModel;
using System.Drawing.Imaging;
namespace Gallery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {

        IList<System.Windows.Controls.Image> images = new List<System.Windows.Controls.Image>();

        public MainWindow()
        {
            InitializeComponent();
        }
        private List<string> filter = new List<string>() { @"bmp", @"jpg", @"gif", @"png" };
        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new System.Windows.Forms.FolderBrowserDialog();
            System.Windows.Forms.DialogResult result = dialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                textBox.Text = dialog.SelectedPath;
                foreach (string file in Directory.GetFiles(dialog.SelectedPath))
                {
                    if (filter.Exists(n => n == file.Split(new char[] { '.' }).Last().ToLower()))
                    {
                        try
                        {
                            var bi = new BitmapImage(new Uri(file));

                            var img = new System.Windows.Controls.Image();
                            bi.DecodePixelWidth = 200;
                            bi.CacheOption = BitmapCacheOption.OnLoad;
                            img.Source = bi; img.Height = 100;
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

        }

        private void OnPhotoClick(object sender, MouseButtonEventArgs e)
        {

            frmViewer pvWindow = new frmViewer();
            pvWindow.SelectedPhoto = (Photo)listbox.SelectedItem;
            pvWindow.Show();
        }
    }
    public class Photo
    {
        public Photo(string path)
        {
            _path = path;
            _source = new Uri(path);
            _image = BitmapFrame.Create(_source);

        }
        public override string ToString()
        {
            return _source.ToString();
        }

        private string _path;

        private Uri _source;
        public string Source { get { return _path; } }

        private BitmapFrame _image;
        public BitmapFrame Image { get { return _image; } set { _image = value; } }
    }
}