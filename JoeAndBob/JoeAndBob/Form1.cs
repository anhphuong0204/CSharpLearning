using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoeAndBob
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;
        public void UpdateForm()
        {
            joeCashLabel.Text = "Joe has " + joe.Cash;
            bobCashLabel.Text = "Bob has " + bob.Cash;
            bankCashLabel.Text = "Bank has " + bank;
        }
        public Form1()
        {
            InitializeComponent();
            joe = new Guy() { Cash = 100, Name = "Joe" };
            bob = new Guy() { Cash = 50, Name = "Bob" };
            bank = 200;
            UpdateForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Bank is outa money");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void joeGivesBob_Click(object sender, EventArgs e)
        {
            bob.ReceiveCash(joe.GiveCash(5));
            UpdateForm();
        }

        private void bobGivesJoe_Click(object sender, EventArgs e)
        {
            joe.ReceiveCash(bob.GiveCash(10));
            UpdateForm();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
