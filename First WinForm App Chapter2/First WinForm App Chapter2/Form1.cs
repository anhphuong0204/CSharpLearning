using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_WinForm_App_Chapter2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void changeText_Click(object sender, EventArgs e)
        {
            if (enableCheckBox.Checked == true)
            {
                if (toChangeLabel.Text == "Right")
                {
                    toChangeLabel.Text = "Left";
                    toChangeLabel.TextAlign = ContentAlignment.MiddleLeft;
                }
                else
                {
                    toChangeLabel.Text = "Right";
                    toChangeLabel.TextAlign = ContentAlignment.MiddleRight;
                }
            }
            else
            {
                toChangeLabel.Text = "Check box is disable";
                toChangeLabel.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
    }
}
