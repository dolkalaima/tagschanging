using System;
using System.Collections.Generic;
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
using Microsoft.Win32;

namespace TagsChanging
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenBt_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "ntl files (*.ntl)|*.ntl";
            if (openFileDialog1.ShowDialog() == true)
            {
                string[] lines = File.ReadAllLines(openFileDialog1.FileName, Encoding.GetEncoding(1251));
                CommandsList.ItemsSource = lines;
            }
        }

        private void NewBt_OnClick(object sender, RoutedEventArgs e)
        {
            CommandsList.ItemsSource = null;
        }

        private void AddBt_OnClick(object sender, RoutedEventArgs e)
        {
           EditWindow ew = new EditWindow();
            ew.Show();
        }
    }
}
