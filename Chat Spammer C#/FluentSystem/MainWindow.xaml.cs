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
using System.Windows.Forms;

namespace FluentSystem
{


    public partial class MainWindow
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }
        

        private void intervallo_TextChanged(object sender, TextChangedEventArgs e) {

            string temp = "";
            for (int i = 0; i < intervallo.Text.Length; i++)
            {
                char a = intervallo.Text[i];
                if (a == '0' || a == '1' || a == '2' || a == '3' || a == '4' || a == '5' || a == '6' || a == '7' || a == '8' || a == '9')
                {
                    temp += intervallo.Text[i];
                }
            }
            intervallo.Text = temp;

        }
        public bool finish = false;
        private void Button1_Click_1(object sender, RoutedEventArgs e)
        {

            Window2 new2 = new Window2();
            
           

            System.Windows.Forms.MessageBox.Show("Inizio countdown!");
            System.Threading.Thread.Sleep(5000);
            new2.Show();
            for (int i = 0; i < Int32.Parse(numero.Text)||finish!=false; i++)
            {
                System.Threading.Thread.Sleep(Int32.Parse(intervallo.Text));
                SendKeys.SendWait(messaggio.Text);
      
                SendKeys.SendWait("{ENTER}");
            }
            finish = false;
        }

        private void Button2_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 newwindow = new Window1();
            newwindow.Show();
        }

        private void numero_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        
            string temp = "";
            for (int i = 0; i < numero.Text.Length; i++)
            {
                char a = numero.Text[i];
                if (a == '0' || a == '1' || a == '2' || a == '3' || a == '4' || a == '5' || a == '6' || a == '7' || a == '8' || a == '9')
                {
                    temp += numero.Text[i];
                }
            }
            numero.Text = temp;
          
      
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

           

        }

        
    }
}

