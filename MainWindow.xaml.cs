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

namespace WPF01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// Original by Computer Science channel: https://youtu.be/Wh2HMyv8unM
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        // Hello text.

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (RadioButton01.IsChecked == true)
            {
                MessageBox.Show("Hello.");
            }
            else if (RadioButton02.IsChecked == true)
            {
                MessageBox.Show("Goodbye.");
            }
        }

        private void Credits_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Original implemenation by Computer Science YouTube channel: https://youtu.be/Wh2HMyv8unM");
        }

        // Goodbye text.
    }
}
