using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcPartyFeeVer2
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;
        public Form1()
        {
            InitializeComponent();

            dinnerParty = new DinnerParty((int)numericUpDown1.Value, decorationCheckbox.Checked, beverageCheckbox.Checked);
            DisplayDinnerCost();

            birthdayParty = new BirthdayParty((int)numericUpDown2.Value, fancyCheckbox.Checked, cakeWriting.Text);
            DisplayBirthdayCost();
        }
        private void DisplayDinnerCost()
        {
            decimal cost = dinnerParty.Cost;
            costLabel.Text = cost.ToString("c");
        }
        private void DisplayBirthdayCost()
        {
            tooLongLabel.Visible = birthdayParty.CakeWritingTooLong;
            decimal cost = birthdayParty.Cost;
            costBirthdayParty.Text = cost.ToString("c");
        }

        // Dinner Party Control
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerCost();
        }

        private void decorationCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecoration = decorationCheckbox.Checked;
            DisplayDinnerCost();
        }

        private void beverageCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = beverageCheckbox.Checked;
            DisplayDinnerCost();
        }


        // Birthday Party Control
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumOfPeople = (int)numericUpDown2.Value;
            DisplayBirthdayCost();
        }

        private void fancyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecoration = fancyCheckbox.Checked;
            DisplayBirthdayCost();
        }

        private void cakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = cakeWriting.Text;
            DisplayBirthdayCost();
        }
    }
}
