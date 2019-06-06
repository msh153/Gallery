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
using System.ComponentModel;
using System.Threading;
using ProgressBar = System.Windows.Forms.ProgressBar;
using System.ComponentModel;
using DataFormats = System.Windows.Forms.DataFormats;

namespace Gallery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public List<Image> images = new List<Image>();
        private List<string> filter = new List<string>() { @"bmp", @"jpg", @"gif", @"png" };
        Dictionary<Image, DateTime> photos = new Dictionary<Image, DateTime>();
        public MainWindow()
        {
            InitializeComponent();

        }
        bool check;
        public void Add()
        {
            string path = editor.Add();
            BitmapImage bi = new BitmapImage(new Uri(path))
            {
                CacheOption = BitmapCacheOption.OnLoad
            };

            Image img = new Image
            {
                Source = bi,
                Width = 150,
                Height = 100
            };
            images.Add(img);
            listbox.ItemsSource = images;
        }
        FileInfo[] files;
        bool loadoraddb;
        private void LoadorAdd()
        {
            if (loadoraddb)
            {
                images.Clear();
                photos.Clear();
            }
            listbox.ItemsSource = null;
            DirectoryInfo info = new DirectoryInfo(textBox.Text);
            try
            {
                files = info.GetFiles().OrderBy(p => p.Name).ToArray();
                if (check == true)
                    switch ((ComboBoxShow.SelectedIndex))
                    {
                        case 0:
                            files = info.GetFiles().OrderBy(p => p.Name).ToArray();
                            break;
                        case 1:
                            files = info.GetFiles().OrderBy(p => p.CreationTime).ToArray();
                            break;
                        case 2:
                            files = info.GetFiles().OrderBy(p => p.LastWriteTime).ToArray();
                            break;
                        case 3:
                            files = info.GetFiles().OrderBy(p => p.Length).ToArray();
                            break;
                    }
                else
                    switch ((ComboBoxShow.SelectedIndex))
                    {
                        case 0:
                            files = info.GetFiles().OrderByDescending(p => p.Name).ToArray();
                            break;
                        case 1:
                            files = info.GetFiles().OrderByDescending(p => p.CreationTime).ToArray();
                            break;
                        case 2:
                            files = info.GetFiles().OrderByDescending(p => p.LastWriteTime).ToArray();
                            break;
                        case 3:
                            files = info.GetFiles().OrderByDescending(p => p.Length).ToArray();
                            break;
                    }
            }
            catch
            {
                MessageBox.Show("Folder path is not correct");
            }

            foreach (FileInfo file in files)
            {
                    if (filter.Exists(n => n == file.Name.Split('.').Last().ToLower()))
                {
                        BitmapImage bi = new BitmapImage(new Uri(file.FullName));

                    Image img = new Image
                    {
                        Source = bi,
                        Width = 150,
                        Height = 100
                    };
                    images.Add(img);
                    photos.Add(img, file.CreationTimeUtc); 
                }
            }
            listbox.ItemsSource = images;
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            loadoraddb = false;
            LoadorAdd();
        }
        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            loadoraddb = true;
            LoadorAdd();
        }
        private void OnPhotoClick(object sender, MouseButtonEventArgs e)
        {

            frmViewer pvWindow = new frmViewer
            {
                SelectedPhoto = (Image)listbox.SelectedItem,
                Images = images,
            };
            pvWindow.Show();
        }

        private void Open_Folder_Click(object sender, RoutedEventArgs e)
        {
            label_date.Visibility = Visibility.Hidden;
            pbInterminate.Visibility = Visibility.Visible;
            var dialog = new System.Windows.Forms.FolderBrowserDialog();
            System.Windows.Forms.DialogResult result = dialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                textBox.Text = dialog.SelectedPath;
            }
            pbInterminate.Visibility = Visibility.Hidden;
            label_date.Visibility = Visibility.Visible;
        }

        private void StartSlideShowButton_Click(object sender, RoutedEventArgs e)
        {

            frmViewer pvWindow = new frmViewer
            {
                SelectedPhoto = (Image)listbox.SelectedItem,
                Images = images,
                needAnimation = true,
                interval = Convert.ToInt32(textBox_interval.Text),
                Check = check
            };
            pvWindow.Show();
        }

        private void Button_create_Click(object sender, RoutedEventArgs e)
        {
            editor p = new editor();
            p.Show();
            button_update.Visibility = Visibility.Visible;
        }

        private void CheckBoxDescending_Unchecked(object sender, RoutedEventArgs e)
        {
            check = false;
        }

        private void CheckBoxDescending_Checked(object sender, RoutedEventArgs e)
        {
            check = true;
        }

        private void TextBoxSearch_MouseUp(object sender, RoutedEventArgs e)
        {
            textBoxSearch.Foreground = Brushes.Black;
            textBoxSearch.Text = "";
        }

        private void TextBoxSearch_LostFocus(object sender, RoutedEventArgs e)
        {
            textBoxSearch.Foreground = Brushes.Silver;
            textBoxSearch.Text = "Enter value";
        }
        public List<Image> deleted = new List<Image>();


        private void ButtonSearch_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in images)
            {
                deleted.Add(item);
            }
            images.Clear();
            listbox.ItemsSource = null;
            switch ((ComboBoxSearch.SelectedIndex))
            {
                case 0:
                    foreach (var pair in photos)
                    {
                        short b;
                        Int16.TryParse(textBoxSearch.Text, out b);
                        short c = Convert.ToInt16(pair.Value.ToString("dd"));
                        if (b == c)
                        {
                            Image img = pair.Key;
                            images.Add(img); 
                        }
                    }
                    break;
                case 1:
                    foreach (var pair in photos)
                    {
                        short b;
                        Int16.TryParse(textBoxSearch.Text, out b);

                        short c = Convert.ToInt16(pair.Value.ToString("MM"));
                        if (b == c)
                        {
                            Image img = pair.Key;
                            images.Add(img);
                        }
                    }
                    break;
                case 2:
                    foreach (var pair in photos)
                    {
                        short b;
                        Int16.TryParse(textBoxSearch.Text, out b);

                        short c = Convert.ToInt16(pair.Value.ToString("yyyy"));
                        if (b == c)
                        {
                            Image img = pair.Key;
                            images.Add(img);
                        }
                    }
                    break;
            }
            if (!check)
                photos = photos.OrderBy(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
            else
                photos = photos.OrderByDescending(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
            foreach (var pair in photos)
            {
                Image img = pair.Key;
                images.Add(img);
            }
            button_back.Visibility = Visibility.Visible;
            if (!images.Any()) { MessageBox.Show("Not found!", "Not found", MessageBoxButton.OK, MessageBoxImage.Error); button_back.Visibility = Visibility.Hidden; }
            else
            listbox.ItemsSource = images;
        }

        private void Button_update(object sender, RoutedEventArgs e)
        {
            Add();
            button_update.Visibility = Visibility.Hidden;
        }

        private void Listbox_Drop(object sender, System.Windows.DragEventArgs e)
        {
            listbox.ItemsSource = null;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                
                for (int i = 0; i < files.Count(); i++)
                {
                    if (filter.Exists(n => n == files[i].Split('.').Last().ToLower()))
                    {
                        var bi = new BitmapImage(new Uri(files[i]));
                        var img = new System.Windows.Controls.Image
                        {
                            Source = bi,
                            Width = 150,
                            Height = 100
                        };
                        images.Add(img);
                        photos.Add(img, File.GetCreationTime(files[i]));
                    }
                    
                }
                listbox.ItemsSource = images;
            }
        }

        private void Listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (var pair in photos)
            {
                if (listbox.SelectedItem == pair.Key)
                {
                    label_date.Content = pair.Value;
                }
            }
            //label_date.Content = photos.SingleOrDefault(x => x.Key == listbox.SelectedItem).Value;
        }

        private void Button_back(object sender, RoutedEventArgs e)
        {
            listbox.ItemsSource = null;
            images.Clear();
            foreach (var item in deleted)
            {
                images.Add(item);
            }
            listbox.ItemsSource = images;
            button_back.Visibility = Visibility.Hidden;
            deleted.Clear();
            }
  
        public void MenuItem_Click_Remove(object sender, RoutedEventArgs e)
        {
            listbox.ItemsSource = null;
            foreach (var item in images)
            {
                deleted.Add(item);
            }
            button_back.Visibility = Visibility.Visible;
            images.Clear();
            listbox.ItemsSource = images;
        }

      

     
        private void SortDate_Click(object sender, RoutedEventArgs e)
        {
            listbox.ItemsSource = null;
            images.Clear();
            if (!check)
            photos = photos.OrderBy(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
            else
                photos = photos.OrderByDescending(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
            foreach (var pair in photos)
            {
                Image img = pair.Key;
                images.Add(img);
            }
            listbox.ItemsSource = images;
        }
    }
}
