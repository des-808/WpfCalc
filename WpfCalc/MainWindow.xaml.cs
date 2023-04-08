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
        private void btn_CE_click(object sender, RoutedEventArgs e){ new_sample.Text = "0"; old_sample.Text = ""; }// сбросить всё
        private void btn_C_click(object sender, RoutedEventArgs e) { new_sample.Text = "0"; }//сбросить последнее выражение
        private void btn_Del_click(object sender, RoutedEventArgs e){ 
            if (new_sample.Text.Length> 0) { new_sample.Text = new_sample.Text.Remove(new_sample.Text.Length - 1); }// вырезаем последний символ
        }
        
        //private void btn_1_click(object sender, RoutedEventArgs e)      { del_new_samle(); xxx = new_sample.Text.Equals("0") ? new_sample.Text = "1" : new_sample.Text += "1"; }
        private void btn_1_click(object sender, RoutedEventArgs e)      { del_new_samle(); xxx = iss_zero(new_sample.Text, "1"); }
        private void btn_2_click(object sender, RoutedEventArgs e)      { del_new_samle(); xxx = iss_zero(new_sample.Text, "2"); }
        private void btn_3_click(object sender, RoutedEventArgs e)      { del_new_samle(); xxx = iss_zero(new_sample.Text, "3"); }
        private void btn_4_click(object sender, RoutedEventArgs e)      { del_new_samle(); xxx = iss_zero(new_sample.Text, "4"); }
        private void btn_5_click(object sender, RoutedEventArgs e)      { del_new_samle(); xxx = iss_zero(new_sample.Text, "5"); }
        private void btn_6_click(object sender, RoutedEventArgs e)      { del_new_samle(); xxx = iss_zero(new_sample.Text, "6"); }
        private void btn_7_click(object sender, RoutedEventArgs e)      { del_new_samle(); xxx = iss_zero(new_sample.Text, "7"); }
        private void btn_8_click(object sender, RoutedEventArgs e)      { del_new_samle(); xxx = iss_zero(new_sample.Text, "8"); }
        private void btn_9_click(object sender, RoutedEventArgs e)      { del_new_samle(); xxx = iss_zero(new_sample.Text, "9"); }
        private void btn_0_click(object sender, RoutedEventArgs e)      { del_new_samle(); xxx = iss_zero(new_sample.Text, "0"); }
        private void btn_Tchk_click(object sender, RoutedEventArgs e)   { new_sample.Text += "."; }
        private void btn_Add_click(object sender, RoutedEventArgs e)    { old_sample.Text = "+"; old_sample.Text += new_sample.Text; bool_deystvie = true; operaciya = '+'; deystviee(); }
        private void btn_Sub_click(object sender, RoutedEventArgs e)    { old_sample.Text = "-"; old_sample.Text += new_sample.Text; bool_deystvie = true; operaciya = '-'; deystviee(); }
        private void btn_Mul_click(object sender, RoutedEventArgs e)    { old_sample.Text = "*"; old_sample.Text += new_sample.Text; bool_deystvie = true; operaciya = '*'; deystviee(); }
        private void btn_Div_click(object sender, RoutedEventArgs e)    { if (!new_sample.Text.Equals("0")) { old_sample.Text = "/"; old_sample.Text += new_sample.Text; bool_deystvie = true; operaciya = '/'; deystviee(); } }
        private void btn_Equals_click(object sender, RoutedEventArgs e){
            string old_text = old_sample.Text;
            char[] delimiterChars = { '+', '-', '*', '/','='};
            //char[] delimiterChars = { '='};
            char[] delimiterInt = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0','=' };
            string[] xz = old_sample.Text.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            string[] xy = new_sample.Text.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            string[] ot = old_text.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            double Left = Convert.ToDouble(xz[0]);
            //double Right = Convert.ToDouble(xy[0]);
            double Right = Convert.ToDouble(xy[0]);
            double otvet = calculatoR.Operation(Left, Right, operaciya);
            
            string otvet_string = otvet.ToString();
            if (otvet < 0) { otvet_string = calculatoR.revers_string(otvet_string); }
            //old_sample.Text = $"{Left}{operators}{Right}={otvet}";
            //old_sample.Text = ot[0] +operaciya+xxx+'=';
            old_sample.Text = $"={calculatoR.revers_string(old_sample.Text)+new_sample.Text}";//$"{Left}{operators}{Right}={otvet}";
            //string wwww = ot[0] + operaciya + xxx + '=';
            //old_sample.Text = revers_string( wwww);
            //old_sample.Text = $"={revers_string(ot[0]) +new_sample.Text}";//$"{Left}{operators}{Right}={otvet}";
            new_sample.Text = otvet_string;
        }
        private string iss_zero(string text,string btn_number) 
        {
             text = text.Equals("0") ? new_sample.Text = btn_number : new_sample.Text += btn_number;
            return text; 
        }
        private void deystviee() {
            //if (old_sample.Text != new_sample.Text) { 
            //char[] delimiterChars = { '+', '-', '*', '/' };
            ////char[] delimiterInt = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            //string[] xz = old_sample.Text.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            //string[] xy = new_sample.Text.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            //double Left = Convert.ToDouble(xz[0]);
            //double Right = Convert.ToDouble(xy[0]);
            //double otvet = 0;
            //switch (deystvie)
            //{
            //    case 1: otvet = mathematicA.Add(Left, Right); break;
            //    case 2: otvet = mathematicA.Sub(Left, Right); break;
            //    case 3: otvet = mathematicA.Mul(Left, Right); break;
            //    case 4: otvet = mathematicA.Div(Left, Right); break;
            //    default:
            //        break;
            //}
            //string otvet_string = otvet.ToString();
            //if (otvet < 0) { otvet_string = revers_string(otvet_string); }
            ////old_sample.Text = $"{Left}{operators}{Right}={otvet}";
            //old_sample.Text = $"{otvet_string}={revers_string(old_sample.Text) + new_sample.Text}";//$"{Left}{operators}{Right}={otvet}";
            //new_sample.Text = otvet_string;
            //}
        }
        private void del_new_samle() { if (bool_deystvie) { new_sample.Text = ""; bool_deystvie = false; } }
        
        class CalculatoR {
            public string revers_string(string text)
            {
                char[] delimiterChars = { '+', '-', '*', '/', '=' };
                char[] delimiterInt = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
                string[] zx = text.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                string[] zy = text.Split(delimiterInt, StringSplitOptions.RemoveEmptyEntries);
                if (zx.Length > 1 && zy.Length > 1) { return zx[0] + zy[0] + zx[1] + zy[1]; }
                return zx[0] + zy[0];
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
