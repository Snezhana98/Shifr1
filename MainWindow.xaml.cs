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

namespace Shifr1
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

        private void ShifrClick(object sender, RoutedEventArgs e)
        {
            OpenWrite file = new OpenWrite();
            byte[] k = file.open();
            byte[] m = ShifrDeshifr.Shifrovka(k);
            OpenWrite file2 = new OpenWrite();
            file2.write(m);
        }

        private void DeshifrClick(object sender, RoutedEventArgs e)
        {
            OpenWrite file = new OpenWrite();
            byte[] k = file.open();
            byte[] m = ShifrDeshifr.Deshifrovka(k);
            OpenWrite file2 = new OpenWrite();
            file2.write(m);
        }
    }
}
