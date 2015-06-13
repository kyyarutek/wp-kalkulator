using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Kalkulator1
{

    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        public class Dane //stworzenie klasy publicznej dla danych
        {
            public static double a = 0, b = 0, wynik=0;
            public static string znak = "";
        }

        private void button_1_Click(object sender, RoutedEventArgs e)// liczby dla button's od 0-9
        {
            textBox_wynik.Text = textBox_wynik.Text + "1";

        }

        private void button_2_Click(object sender, RoutedEventArgs e)
        {
            textBox_wynik.Text = textBox_wynik.Text + "2";
        }

        private void button_3_Click(object sender, RoutedEventArgs e)
        {
            textBox_wynik.Text = textBox_wynik.Text + "3";
        }

        private void button_4_Click(object sender, RoutedEventArgs e)
        {
            textBox_wynik.Text = textBox_wynik.Text + "4";
        }

        private void button_5_Click(object sender, RoutedEventArgs e)
        {
            textBox_wynik.Text = textBox_wynik.Text + "5";
        }

        private void button_6_Click(object sender, RoutedEventArgs e)
        {
            textBox_wynik.Text = textBox_wynik.Text + "6";
        }

        private void button_7_Click(object sender, RoutedEventArgs e)
        {
            textBox_wynik.Text = textBox_wynik.Text + "7";
        }

        private void button_8_Click(object sender, RoutedEventArgs e)
        {
            textBox_wynik.Text = textBox_wynik.Text + "8";
        }

        private void button_9_Click(object sender, RoutedEventArgs e)
        {
            textBox_wynik.Text = textBox_wynik.Text + "9";
        }

        private void button_0_Click(object sender, RoutedEventArgs e)
        {
            textBox_wynik.Text = textBox_wynik.Text + "0";
        }

        private void button_dodaj_Click(object sender, RoutedEventArgs e)//rozpoznanie znaku plus
        {
            Dane.a =Convert.ToDouble( textBox_wynik.Text);
            textBox_wynik.Text = "";
            Dane.znak = "+";
        }

        private void button_wynik_Click(object sender, RoutedEventArgs e)
        {
            Dane.b = Convert.ToDouble(textBox_wynik.Text);
            if (Dane.znak == "+") Dane.wynik = Dane.a + Dane.b;//dodawanie
            textBox_wynik.Text = Convert.ToString(Dane.wynik);
            if (Dane.znak == "-") Dane.wynik = Dane.a - Dane.b;//odejmowanie
            textBox_wynik.Text = Convert.ToString(Dane.wynik);
            if (Dane.znak == "*") Dane.wynik = Dane.a * Dane.b;//mnozenie
            textBox_wynik.Text = Convert.ToString(Dane.wynik);
            if (Dane.znak == "/" && Dane.b != 0) Dane.wynik = Dane.a / Dane.b;//dzielenie
            textBox_wynik.Text = Convert.ToString(Dane.wynik);
            if (Dane.znak == "/" && Dane.b == 0) //zablokowanie dzielenia przez zero
            textBox_wynik.Text = "nieprawidlowe dzialanie";
            }
        private void minus_Click(object sender, RoutedEventArgs e)//rozpoznanie znaku minus
        {
            Dane.a = Convert.ToDouble(textBox_wynik.Text);
            textBox_wynik.Text = "";
            Dane.znak = "-";

        }

        private void mnozenie_Click(object sender, RoutedEventArgs e)//rozpoznanie znaku mnozenie
        {
            Dane.a = Convert.ToDouble(textBox_wynik.Text);
            textBox_wynik.Text = "";
            Dane.znak = "*";
        }
        

        private void kropka_Click(object sender, RoutedEventArgs e)//wprowadzanie kropki
        {
            textBox_wynik.Text = textBox_wynik.Text + ".";
        }

        private void button1_Click(object sender, RoutedEventArgs e)//rozpoznanie znaku dzielenia
        {
            Dane.a = Convert.ToDouble(textBox_wynik.Text);
            textBox_wynik.Text = "";
            Dane.znak = "/";
        }

        private void kasowanie_Click(object sender, RoutedEventArgs e)//znak wyniku
        {
            textBox_wynik.Text = "";
        }
    }
}