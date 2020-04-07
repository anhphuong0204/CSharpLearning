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

namespace TestStatementInCSharp
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string myName = "Taki Nguyen";
            int myAge = 20;
            myLabel.Text = "Hello everyone, my name is " + myName + "\nAnd I am " + myAge + " years old";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            bool alive = true;
            if (alive)
                myLabel.Text = "I am alive";
            else
                myLabel.Text = "I am dead";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (true)
                myLabel.Text = "Run!";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            myLabel.Text = "";
            for (int i = 0; i < 3; i++)
            {
                myLabel.Text += i * 6;
                myLabel.Text += " ";
            }
        }
    }
}
