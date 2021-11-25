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
            calcDisplay.Text = "";
            userInput += "0";
            calcDisplay.Text += userInput;
        }

        private void num1_Click(object sender, RoutedEventArgs e)
        {
            calcDisplay.Text = "";
            userInput += "1";
            calcDisplay.Text += userInput;
        }

        private void num2_Click(object sender, RoutedEventArgs e)
        {
            calcDisplay.Text = "";
            userInput += "2";
            calcDisplay.Text += userInput;
        }

        private void num3_Click(object sender, RoutedEventArgs e)
        {
            calcDisplay.Text = "";
            userInput += "3";
            calcDisplay.Text += userInput;
        }

        private void num4_Click(object sender, RoutedEventArgs e)
        {
            calcDisplay.Text = "";
            userInput += "4";
            calcDisplay.Text += userInput;
        }

        private void num5_Click(object sender, RoutedEventArgs e)
        {
            calcDisplay.Text = "";
            userInput += "5";
            calcDisplay.Text += userInput;
        }

        private void num6_Click(object sender, RoutedEventArgs e)
        {
            calcDisplay.Text = "";
            userInput += "6";
            calcDisplay.Text += userInput;
        }

        private void num7_Click(object sender, RoutedEventArgs e)
        {
            calcDisplay.Text = "";
            userInput += "7";
            calcDisplay.Text += userInput;
        }

        private void num8_Click(object sender, RoutedEventArgs e)
        {
            calcDisplay.Text = "";
            userInput += "8";
            calcDisplay.Text += userInput;
        }

        private void num9_Click(object sender, RoutedEventArgs e)
        {
            calcDisplay.Text = "";
            userInput += "9";
            calcDisplay.Text += userInput;
        }

        private void decimalButton_Click(object sender, RoutedEventArgs e)
        {
            calcDisplay.Text = ".";
            //userInput = firstValue+".";
            //calcDisplay.Text += userInput;
        }

        private void plusButton_Click(object sender, RoutedEventArgs e)
        {
            rodzajDzialania = '+';
            firstValue = userInput;
            userInput = "";
        }

        private void minusButton_Click(object sender, RoutedEventArgs e)
        {
            rodzajDzialania = '-';
            firstValue = userInput;
            userInput = "";
        }

        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {
            rodzajDzialania = '*';
            firstValue = userInput;
            userInput = "";
        }

        private void divideButton_Click(object sender, RoutedEventArgs e)
        {
            rodzajDzialania = '/';
            firstValue = userInput;
            userInput = "";
        }

        private void equalButton_Click(object sender, RoutedEventArgs e)
        {
            secondValue = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(firstValue);
            secondNum = Convert.ToDouble(secondValue);

            //Dodawanie
            if (rodzajDzialania == '+')
            {
                result = firstNum + secondNum;
                calcDisplay.Text = result.ToString();
            }
            //Odejmowanie
            else if (rodzajDzialania == '-')
            {
                result = firstNum - secondNum;
                calcDisplay.Text = result.ToString();
            }
            //Mnożenie
            else if (rodzajDzialania == '*')
            {
                result = firstNum * secondNum;
                calcDisplay.Text = result.ToString();
            }
            //Dzielenie
            else if (rodzajDzialania == '/')
            {
                if (secondNum == '0')
                {
                    calcDisplay.Text = "Moron";
                }
                else
                {
                    result = firstNum / secondNum;
                    calcDisplay.Text = result.ToString();
                }
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            firstValue = "";
            secondValue = "";
            userInput = "";
            result = 0.0;
            calcDisplay.Text = "0";
        }
    }
}
