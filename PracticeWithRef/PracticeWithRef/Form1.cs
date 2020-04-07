using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeWithRef
{
    public partial class Form1 : Form
    {
        Elephant adam;
        Elephant eva;
        public Form1()
        {
            InitializeComponent();

            adam = new Elephant() { Name = "Adam", EarSize = 90 };
            eva = new Elephant() { Name = "Eva", EarSize = 45 };
        }

        private void swapBtn_Click(object sender, EventArgs e)
        {
            Elephant temp;
            temp = adam;
            adam = eva;
            eva = temp;
        }

        private void elephant1_Click(object sender, EventArgs e)
        {
            adam.WhoIAm();
        }

        private void elephant2_Click(object sender, EventArgs e)
        {
            eva.WhoIAm();
        }
    }
}
