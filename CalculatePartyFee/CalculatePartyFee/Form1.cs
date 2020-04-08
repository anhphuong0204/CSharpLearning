using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatePartyFee
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty();
            dinnerParty.SetHealthyOption(false);
            dinnerParty.SetPartyOption((int)numericUpDown1.Value, true);
            DisplayCost();
        }
        private void DisplayCost()
        {
            decimal cost = dinnerParty.CalculateCost(checkBox1.Checked);
            costLabel.Text = cost.ToString("c");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.SetPartyOption((int)numericUpDown1.Value, checkBox2.Checked);
            DisplayCost();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetPartyOption((int)numericUpDown1.Value, checkBox2.Checked);
            DisplayCost();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(checkBox1.Checked);
            DisplayCost();
        }
    }
}
