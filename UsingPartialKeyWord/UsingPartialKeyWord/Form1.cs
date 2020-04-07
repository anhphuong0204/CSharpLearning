using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingPartialKeyWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toChangeColorBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
            while (Visible)
            {
                for (int i = 0; i < 254 && Visible; i++)
                {
                    this.BackColor = Color.FromArgb(i, 255 - i, i);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(10);
                }
                for (int i = 253; i > -1 && Visible; i--)
                {
                    this.BackColor = Color.FromArgb(i, 255 - i, i);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(10);
                }
            }
        }
    }
}
