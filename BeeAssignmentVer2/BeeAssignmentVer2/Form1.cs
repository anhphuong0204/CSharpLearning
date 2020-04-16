using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeAssignmentVer2
{
    public partial class Form1 : Form
    {
        Queen queen;
        public Form1()
        {
            InitializeComponent();
            //Baby bee tutoring
            //Egg care
            //Hive maintance
            //Honey manufacturing
            //Nectar collection
            //Sting patrol
            Worker[] workers = new Worker[5];
            workers[0] = new Worker(new string[] { "Baby bee tutoring", "Sting patrol", "Egg care" }, 175);
            workers[1] = new Worker(new string[] { }, 3140);
            workers[2] = new Worker(new string[] { "Hive maintance", "Sting patrol" }, 100);
            workers[3] = new Worker(new string[] { "Honey manufacturing" }, 150);
            workers[4] = new Worker(new string[] { "Nectar collection" }, 148);
            queen = new Queen(workers, 275);
        }

        private void assignBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(listOfJobs.Text))
            {
                MessageBox.Show("There is no work in work assignment field!");
                return;
            }
            if (queen.AssignWork(listOfJobs.Text, (int)numericUpDown1.Value))
            {
                MessageBox.Show(listOfJobs.Text + " has been assigned in " + (int)numericUpDown1.Value + " shifts", "The queen says: ");
                return;
            }
            MessageBox.Show("No workers are available right now for " + listOfJobs.Text, "The queen says:");
        }

        private void workBtn_Click(object sender, EventArgs e)
        {
            string report = queen.WorkTheNextShift();
            reportTextBox.Text = report;
        }
    }
}
