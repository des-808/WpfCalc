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
using static System.Net.Mime.MediaTypeNames;
//#define ZD5
namespace WpfCalc
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
        string tmp;
        private void btn_CE_click(object sender, RoutedEventArgs e){}
        private void btn_C_click(object sender, RoutedEventArgs e){}
        private void btn_Del_click(object sender, RoutedEventArgs e){ 
            tmp = new_sample.Text;
            if(tmp.Length > 0) { new_sample.Text = tmp.Remove(tmp.Length - 1); }// вырезаем последний символ
        }
        private void btn_Div_click(object sender, RoutedEventArgs e) { tmp = new_sample.Text; tmp += "/"; new_sample.Text = tmp; }
        private void btn_7_click(object sender, RoutedEventArgs e){ tmp = new_sample.Text; tmp += "7"; new_sample.Text = tmp; }
        private void btn_8_click(object sender, RoutedEventArgs e){ tmp = new_sample.Text; tmp += "8"; new_sample.Text = tmp; }
        private void btn_9_click(object sender, RoutedEventArgs e){ tmp = new_sample.Text; tmp += "9"; new_sample.Text = tmp; }
        private void btn_Mul_click(object sender, RoutedEventArgs e) { tmp = new_sample.Text; tmp += "*"; new_sample.Text = tmp; }
        private void btn_4_click(object sender, RoutedEventArgs e){ tmp = new_sample.Text; tmp += "4"; new_sample.Text = tmp; }
        private void btn_5_click(object sender, RoutedEventArgs e){ tmp = new_sample.Text; tmp += "5"; new_sample.Text = tmp; }
        private void btn_6_click(object sender, RoutedEventArgs e){ tmp = new_sample.Text; tmp += "6"; new_sample.Text = tmp; }
        private void btn_Sub_click(object sender, RoutedEventArgs e) { tmp = new_sample.Text; tmp += "-"; new_sample.Text = tmp; }
        private void btn_1_click(object sender, RoutedEventArgs e){ tmp = new_sample.Text; tmp += "1"; new_sample.Text = tmp; }
        private void btn_2_click(object sender, RoutedEventArgs e){ tmp = new_sample.Text; tmp += "2"; new_sample.Text = tmp; }
        private void btn_3_click(object sender, RoutedEventArgs e){ tmp = new_sample.Text; tmp += "3"; new_sample.Text = tmp; }
        private void btn_Add_click(object sender, RoutedEventArgs e) { tmp = new_sample.Text; tmp += "+"; new_sample.Text = tmp; }
        private void btn_Tchk_click(object sender, RoutedEventArgs e) { tmp = new_sample.Text; tmp += "."; new_sample.Text = tmp; }
        private void btn_0_click(object sender, RoutedEventArgs e){ tmp = new_sample.Text; tmp += "0"; new_sample.Text = tmp; }
        private void btn_Equals_click(object sender, RoutedEventArgs e){
            
            string? operation = new_sample.Text;
            char[] delimiterChars = { '+', '-', '*', '/', ',', ' ' };
            char[] delimiterInt = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', ' ' };
            string[] xz = operation.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            string[] xt = operation.Split(delimiterInt, StringSplitOptions.RemoveEmptyEntries);
            double Left = Convert.ToDouble(xz[0]);
            char operators = Convert.ToChar(xt[0]);
            double Right = Convert.ToDouble(xz[1]);
            double otvet = 0;
            switch (operators)
            {
                case '+': otvet = Left + Right; break;
                case '-': otvet = Left - Right; break;
                case '*': otvet = Left * Right; break;
                case '/': otvet = Left / Right; break;
                default:
                    break;
            }
            old_sample.Text = $"{Left}{operators}{Right}={otvet}";
            new_sample.Text = otvet.ToString();
            

        }







    }
}
