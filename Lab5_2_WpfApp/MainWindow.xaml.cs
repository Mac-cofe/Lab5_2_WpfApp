using Microsoft.Win32;
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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab5_2_WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Пункт Открыть  не реализован", "Информация", 0);
            //OpenFileDialog openFileDialog = new OpenFileDialog
            //{
            //    Filter = "Графические файлы (*.jpg)|*.jpg|Все файлы (*.*)|*.*"
            //};
            //if (openFileDialog.ShowDialog() == true)
            //{
            //    //textBox.Text = File.ReadAllText(openFileDialog.FileName);

            //}
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Пункт Сохранить не реализован", "Информация", 0);

            //SaveFileDialog saveFileDialog = new SaveFileDialog
            //{
            //    Filter = "Графические файлы (*.bmp)|*.bmp|Все файлы (*.*)|*.*"
            //};
            //if (saveFileDialog.ShowDialog() == true)
            //{

            //    RenderTargetBitmap bmp = new RenderTargetBitmap((int)canvas.Width, (int)canvas.Height, 96, 96, PixelFormats.Pbgra32);
            //    PngBitmapEncoder png = new PngBitmapEncoder();

            //    png.Frames.Add(BitmapFrame.Create(bmp));

            //    using (Stream stm = File.Create(saveFileDialog.FileName))

            //    {

            //        png.Save(stm);

        //     }
        //}
        }

        

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)          // черный цвет 
        {
            if (canvas != null)
            {
                canvas.DefaultDrawingAttributes.Color = Color.FromRgb(0, 0, 0);
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)            // красный цвет 
        {
            if (canvas != null)
            {
                canvas.DefaultDrawingAttributes.Color = Colors.Red;
            }
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)             // зеленый цвет 
        {
            if (canvas != null)
            {
                canvas.DefaultDrawingAttributes.Color = Colors.Green;
            }
        }

        private void RadioButton_Checked_4(object sender, RoutedEventArgs e)
        {
            if (canvas != null)
            {
                canvas.DefaultDrawingAttributes.Width = 12;
            }
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            if (canvas != null)
            {
                canvas.DefaultDrawingAttributes.Width = 3;
            }
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            this.canvas.Strokes.Clear();
        }
    }
}
