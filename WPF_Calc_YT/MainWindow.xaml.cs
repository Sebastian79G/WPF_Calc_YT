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

namespace WPF_Calc_YT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string firstValue = "";
        string secondValue = "";
        char rodzajDzialania;
        double result = 0.0;
        string userInput = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void zeroButton_Click(object sender, RoutedEventArgs e)
        {
            calcDisplay.Text += "0";
        }

        private void num1_Click(object sender, RoutedEventArgs e)
        {
            calcDisplay.Text += "1";
        }

        private void num2_Click(object sender, RoutedEventArgs e)
        {
            calcDisplay.Text += "2";
        }

        private void num3_Click(object sender, RoutedEventArgs e)
        {
            calcDisplay.Text += "3";
        }

        private void num4_Click(object sender, RoutedEventArgs e)
        {
            calcDisplay.Text += "4";
        }

        private void num5_Click(object sender, RoutedEventArgs e)
        {
            calcDisplay.Text += "5";
        }

        private void num6_Click(object sender, RoutedEventArgs e)
        {
            calcDisplay.Text += "6";
        }

        private void num7_Click(object sender, RoutedEventArgs e)
        {
            calcDisplay.Text += "7";
        }

        private void num8_Click(object sender, RoutedEventArgs e)
        {
            calcDisplay.Text += "8";
        }

        private void num9_Click(object sender, RoutedEventArgs e)
        {
            calcDisplay.Text += "9";
        }

        private void decimalButton_Click(object sender, RoutedEventArgs e)
        {
            calcDisplay.Text += ".";
        }

        private void plusButton_Click(object sender, RoutedEventArgs e)
        {
            rodzajDzialania = '+';
        }

        private void minusButton_Click(object sender, RoutedEventArgs e)
        {
            rodzajDzialania = '-';
        }

        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {
            rodzajDzialania = '*';
        }

        private void divideButton_Click(object sender, RoutedEventArgs e)
        {
            rodzajDzialania = '/';
        }

        private void equalButton_Click(object sender, RoutedEventArgs e)
        {
            //rodzajDzialania = '=';
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            //rodzajDzialania = 'c';
        }
    }
}
