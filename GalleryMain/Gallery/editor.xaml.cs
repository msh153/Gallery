using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Gallery
{
    /// <summary>
    /// Interaction logic for editor.xaml
    /// </summary>
    public partial class editor : Window
    {
        public editor()
        {
            InitializeComponent();
            mcolor = new ColorRGB();
            mcolor.red = 0;
            mcolor.green = 0;
            mcolor.blue = 0;
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            this.inkCanvas1.Strokes.Clear();
        }
    //    private void AddImage
    //    {
    //        Image image = new Image
    //        {
    //            Width = 100,
    //            Source = new BitmapImage(new Uri(@"/InkCanvasTest;component/Phone.jpg", UriKind.Relative))

    //        };
    //inkCanvas.Children.Add(image);
    //    }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        static string imgPat = @"D:\file.jpeg";
        public static string Add()
        {
            string a = imgPat;
            return a;
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                this.inkCanvas1.EditingMode = InkCanvasEditingMode.None;
                string imgPath = sfd.FileName;
                MemoryStream ms = new MemoryStream();
                FileStream fs = new FileStream(imgPath, FileMode.Create);
                RenderTargetBitmap rtb = new RenderTargetBitmap((int)inkCanvas1.Width, (int)inkCanvas1.Height,96, 96, PixelFormats.Default);
                rtb.Render(inkCanvas1);
                GifBitmapEncoder gifEnc = new GifBitmapEncoder();
                gifEnc.Frames.Add(BitmapFrame.Create(rtb));
                gifEnc.Save(fs);
                fs.Close();
                this.inkCanvas1.EditingMode = InkCanvasEditingMode.Ink;
                MessageBox.Show("File has saved, " + imgPath);

            }
        }
        public class ColorRGB
        {
            public byte red { get; set; }
            public byte green { get; set; }
            public byte blue { get; set; }
        }
        public ColorRGB mcolor { get; set; }

        public Color clr { get; set; }
        private void sld_Color_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            string crlName = slider.Name; 
            double value = slider.Value; 
            if (crlName.Equals("sld_RedColor"))
            {
                mcolor.red = Convert.ToByte(value);
            }
            if (crlName.Equals("sld_GreenColor"))
            {
                mcolor.green = Convert.ToByte(value);
            }
            if (crlName.Equals("sld_BlueColor"))
            {
                mcolor.blue = Convert.ToByte(value);
            }
            
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            this.inkCanvas1.DefaultDrawingAttributes.Color = clr;
        }

        private void cb_Select_checked(object sender, RoutedEventArgs e)
        {
            this.inkCanvas1.EditingMode = InkCanvasEditingMode.Select;

        }

        private void Cb_Select_Unchecked(object sender, RoutedEventArgs e)
        {
            this.inkCanvas1.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            System.Windows.Forms.DialogResult result = op.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                Image imgPhoto = new Image
                {
                    Width = 600,
                    Height = 300,
                    Source = new BitmapImage(new Uri(op.FileName)),

                };
                inkCanvas1.Children.Add(imgPhoto);
            }
            else
                MessageBox.Show("Something wrong");
        }
        }
    }
   