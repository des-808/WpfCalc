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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace WpfCalc
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        char operaciya = ',';
        CalculatoR calculatoR = new CalculatoR();
        private string? xxx;
        bool bool_deystvie = false;
        double tmp;
        double _OtveT_;
        double _Left_;
        double _Right_;
        private void btn_CE_click(object sender, RoutedEventArgs e){ new_sample.Text = "0"; old_sample.Text = ""; }// сбросить всё
        private void btn_C_click(object sender, RoutedEventArgs e) { new_sample.Text = "0"; }//сбросить последнее выражение
        private void btn_Del_click(object sender, RoutedEventArgs e){ 
            if (new_sample.Text.Length> 0) { new_sample.Text = new_sample.Text.Remove(new_sample.Text.Length - 1); }// вырезаем последний символ
        }

        //private void btn_1_click(object sender, RoutedEventArgs e)      { del_new_samle(); xxx = new_sample.Text.Equals("0") ? new_sample.Text = "1" : new_sample.Text += "1"; }
        private void btn_1_click(object sender, RoutedEventArgs e)      { del_new_sample(); _Right_ = Convert.ToDouble(iss_zero(new_sample.Text, "1")); }//xxx = iss_zero(new_sample.Text, "1"); _Right_ = Convert.ToDouble(xxx); }
        private void btn_2_click(object sender, RoutedEventArgs e)      { del_new_sample(); _Right_ = Convert.ToDouble(iss_zero(new_sample.Text, "2")); }//xxx = iss_zero(new_sample.Text, "2"); _Right_ = Convert.ToDouble(xxx); }
        private void btn_3_click(object sender, RoutedEventArgs e)      { del_new_sample(); _Right_ = Convert.ToDouble(iss_zero(new_sample.Text, "3")); }//xxx = iss_zero(new_sample.Text, "3"); _Right_ = Convert.ToDouble(xxx); }
        private void btn_4_click(object sender, RoutedEventArgs e)      { del_new_sample(); _Right_ = Convert.ToDouble(iss_zero(new_sample.Text, "4")); }//xxx = iss_zero(new_sample.Text, "4"); _Right_ = Convert.ToDouble(xxx); }
        private void btn_5_click(object sender, RoutedEventArgs e)      { del_new_sample(); _Right_ = Convert.ToDouble(iss_zero(new_sample.Text, "5")); }//xxx = iss_zero(new_sample.Text, "5"); _Right_ = Convert.ToDouble(xxx); }
        private void btn_6_click(object sender, RoutedEventArgs e)      { del_new_sample(); _Right_ = Convert.ToDouble(iss_zero(new_sample.Text, "6")); }//xxx = iss_zero(new_sample.Text, "6"); _Right_ = Convert.ToDouble(xxx); }
        private void btn_7_click(object sender, RoutedEventArgs e)      { del_new_sample(); _Right_ = Convert.ToDouble(iss_zero(new_sample.Text, "7")); }//xxx = iss_zero(new_sample.Text, "7"); _Right_ = Convert.ToDouble(xxx); }
        private void btn_8_click(object sender, RoutedEventArgs e)      { del_new_sample(); _Right_ = Convert.ToDouble(iss_zero(new_sample.Text, "8")); }//xxx = iss_zero(new_sample.Text, "8"); _Right_ = Convert.ToDouble(xxx); }
        private void btn_9_click(object sender, RoutedEventArgs e)      { del_new_sample(); _Right_ = Convert.ToDouble(iss_zero(new_sample.Text, "9")); }//xxx = iss_zero(new_sample.Text, "9"); _Right_ = Convert.ToDouble(xxx); }
        private void btn_0_click(object sender, RoutedEventArgs e)      { del_new_sample(); _Right_ = Convert.ToDouble(iss_zero(new_sample.Text, "0")); }//xxx = iss_zero(new_sample.Text, "0"); _Right_ = Convert.ToDouble(xxx); }
        private void btn_Tchk_click(object sender, RoutedEventArgs e)   { new_sample.Text += "."; }
        private void btn_Add_click(object sender, RoutedEventArgs e)    { old_sample.Text = "+"; old_sample.Text += new_sample.Text; bool_deystvie = true; operaciya = '+'; }
        private void btn_Sub_click(object sender, RoutedEventArgs e)    { old_sample.Text = "-"; old_sample.Text += new_sample.Text; bool_deystvie = true; operaciya = '-'; }
        private void btn_Mul_click(object sender, RoutedEventArgs e)    { old_sample.Text = "*"; old_sample.Text += new_sample.Text; bool_deystvie = true; operaciya = '*'; }
        private void btn_Div_click(object sender, RoutedEventArgs e)    { if (!new_sample.Text.Equals("0")) { old_sample.Text = "/"; old_sample.Text += new_sample.Text; bool_deystvie = true; operaciya = '/'; } }
        private void btn_Equals_click(object sender, RoutedEventArgs e){
    string revers_str = calculatoR.revers_string( old_sample.Text);
            char[] delimiterChars = { '+', '-', '*', '/','='};
            char[] delimiterInt = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            //string[] xz = old_sample.Text.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            string[] xz = revers_str.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            string[] xy = new_sample.Text.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            _Right_ = _Right_;
            //if(xz.Length==1)
            double Right = Convert.ToDouble(xy[0]);

            if (xz.Length>1) { double Left = xz.Length > 0 ? Convert.ToDouble(xz[1]) : Convert.ToDouble(xz[0]); } 
            else {
                MessageBox.Show(xxx);
            }
            double otvet = calculatoR.Operation(Left, Right, operaciya);
            //string otvet_string = calculatoR.revers_string(otvet.ToString());
            string otvet_string =otvet.ToString();
            if (otvet < 0) { otvet_string = calculatoR.revers_string(otvet_string); }
            new_sample.Text = otvet_string;
            old_sample.Text = $"={Left}{operaciya}{Right}";
            //old_sample.Text = $"={Right}{operaciya}{Left}";
            //old_sample.Text = $"={calculatoR.revers_string(old_sample.Text)+new_sample.Text}";//$"{Left}{operators}{Right}={otvet}";

        }
        private string iss_zero(string text,string btn_number) 
        {
             text = text.Equals("0") ? new_sample.Text = btn_number : new_sample.Text += btn_number;
            return text; 
        }
       
        private void del_new_sample() { if (bool_deystvie) { new_sample.Text = ""; bool_deystvie = false; } }
        
        class CalculatoR {
            public string revers_string(string text)
            {
                char[] delimiterChars = { '+', '-', '*', '/', '=' };
                char[] delimiterInt = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
                string[] zx = text.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                string[] zy = text.Split(delimiterInt, StringSplitOptions.RemoveEmptyEntries);
                string tmp = "";
                for(int i = 0,j = 0; i < zx.Length; i++, j++) {
                tmp += zx[i]; if (j < zy.Length) { tmp += zy[j]; }
                }
                return tmp;
            }
            public double Operation(double Left, double Right, char deystvie) {
                double otvet = 0;
                switch (deystvie)
                {
                    case '+': otvet = Add(Left, Right); break;
                    case '-': otvet = Sub(Left, Right); break;
                    case '*': otvet = Mul(Left, Right); break;
                    case '/': otvet = Div(Left, Right); break;
                    default:
                        break;
                }
                return otvet; 
            }
            private double Add(double x, double y) { x = x + y; return x; }
            private double Sub(double x, double y) { x = x - y; return x; }
            private double Mul(double x, double y) { x = x * y; return x; }
            private double Div(double x, double y) { x = x / y; return x; }

        };

    }
}
