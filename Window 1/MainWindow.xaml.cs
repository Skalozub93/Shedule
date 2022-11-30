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

namespace Window_1
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

        static public string message = "\nOсновы разработки приложений с использованием " +
            "\nWindows Forms и WPF" + "\n 09:00 - 10:20 Classroom 13(+)" + "\n\n Oсновы разработки приложений с использованием " + 
            "\nWindows Forms и WPF" + "\n 10:30 - 11:50 Classroom 13(+)";
        
        static public string message2 = "\nТеория баз данных. Программирование MS SQL Server" +
            "\n09:00 - 10:20 Classroom 13 (+)" + "\n\nТеория баз данных. Программирование MS SQL Server" +
            "\n10:30 - 11:50 Classroom 13 (+)";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string a = "2022-12-01\n";
            MessageBox.Show(a + message);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string a = "2022-12-03\n";
            MessageBox.Show(a + message);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string a = "2022-12-05\n";
            MessageBox.Show(a + message2);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string a = "2022-12-06\n";
            MessageBox.Show(a + message2);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string a = "2022-12-08\n";
            MessageBox.Show(a + message2);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            string a = "2022-12-10\n";
            MessageBox.Show(a + message2);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            string a = "2022-12-12\n";
            MessageBox.Show(a + message2);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            string a = "2022-12-13\n";
            MessageBox.Show(a + message2);
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            string a = "2022-12-15\n";
            MessageBox.Show(a + message2);
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            string a = "2022-12-19\n";
            MessageBox.Show(a + message2);
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            string a = "2022-12-200\n";
            MessageBox.Show(a + message2);
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            string a = "2022-12-22\n";
            MessageBox.Show(a + message2);
        }
    }
}
