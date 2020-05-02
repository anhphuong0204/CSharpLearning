using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ExcuseManagement
{
    public partial class Form1 : Form
    {
        private Excuse currentExcuse = new Excuse();
        private bool formChanged;
        private string excusesFolder;
        public Form1()
        {
            InitializeComponent();
            currentExcuse.LastUsed = lastUsed.Value;
            openExcuse.Enabled = false;
            saveExcuse.Enabled = false;
            randomExcuse.Enabled = false;
        }

        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                this.description.Text = currentExcuse.Description;
                this.results.Text = currentExcuse.Results;
                this.lastUsed.Value = currentExcuse.LastUsed;
                if (!String.IsNullOrEmpty(currentExcuse.ExcusePath))
                    fileDate.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                this.Text = "Excuse Manager";
            }
            else
                this.Text = "Excuse Manager*";
            this.formChanged = changed;
        }

        private void folder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                excusesFolder = folderBrowserDialog1.SelectedPath;
                saveExcuse.Enabled = true;
                randomExcuse.Enabled = true;
                openExcuse.Enabled = true;
            }
        }

        private void saveExcuse_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(description.Text) || String.IsNullOrEmpty(results.Text))
            {
                MessageBox.Show("Please specify an excuse and a result", "Unable to save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            currentExcuse.Description = description.Text;
            currentExcuse.Results = results.Text;
            currentExcuse.LastUsed = lastUsed.Value;
            currentExcuse.Save(excusesFolder + "\\" + lastUsed.Text + ".txt");
        }

        private void openExcuse_Click(object sender, EventArgs e)
        {
            if (formChanged == true)
            {
                openFileDialog1.InitialDirectory = @"C:\Users\ASUS\Desktop\Head First C#\ExcuseManagement\Excuses";
                if (MessageBox.Show("The current excuse has not been saved. Continue?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        currentExcuse = new Excuse(openFileDialog1.FileName);
                        UpdateForm(false);
                    }
                }
            }
            else
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    currentExcuse = new Excuse(openFileDialog1.FileName);
                    UpdateForm(false);
                }
            }
        }

        private void randomExcuse_Click(object sender, EventArgs e)
        {

        }

        private void description_TextChanged(object sender, EventArgs e)
        {
            formChanged = true;
            UpdateForm(true);
        }

        private void results_TextChanged(object sender, EventArgs e)
        {
            formChanged = true;
            UpdateForm(true);
        }
    }
}
