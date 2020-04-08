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
            dinnerParty = new DinnerParty((int)numericUpDown1.Value, decorationCheckbox.Checked, beverageCheckbox.Checked);
            DisplayCost();
        }
        private void DisplayCost()
        {
            decimal cost = dinnerParty.Cost;
            costLabel.Text = cost.ToString("c");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumOfPeople = (int)numericUpDown1.Value;
            DisplayCost();
        }

        private void decorationCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecoration = decorationCheckbox.Checked;
            DisplayCost();
        }

        private void beverageCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = beverageCheckbox.Checked;
            DisplayCost();
        }
    }
}
