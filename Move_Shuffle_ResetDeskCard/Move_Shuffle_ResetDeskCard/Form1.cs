using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Move_Shuffle_ResetDeskCard
{
    public partial class Form1 : Form
    {
        Desk desk1;
        Desk desk2;
        public Form1()
        {
            InitializeComponent();
            ResetDesk(1);
            ResetDesk(2);
            RedrawList(1);
            RedrawList(2);
        }

        private void ResetDesk(int deskNumber)
        {
            if (deskNumber == 1)
            {
                Random random = new Random();
                List<Card> initialCards = new List<Card>();
                int rd = random.Next(1, 10);
                for (int i = 0; i < rd; i++)
                    initialCards.Add(new Card((Suits)random.Next(4), (Values)random.Next(1, 13)));
                desk1 = new Desk(initialCards);
            }
            else
            {
                desk2 = new Desk();
            }
        }
        private void RedrawList(int listNumber)
        {
            if (listNumber == 1)
            {
                label1.Text = "Desk #1 (" + desk1.Count + ")";
                string[] nameArray1 = desk1.GetCardNames().ToArray();
                for (int i = 0; i < nameArray1.Length; i++)
                    listBox1.Items.Add(nameArray1[i]);
            }
            else
            {
                label2.Text = "Desk #2 (" + desk2.Count + ")";
                string[] nameArray2 = desk2.GetCardNames().ToArray();
                for (int i = 0; i < nameArray2.Length; i++)
                    listBox2.Items.Add(nameArray2[i]);
            }
        }

        private void resetDesk1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ResetDesk(1);
            RedrawList(1);
        }

        private void shuffleDesk1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            desk1.Shuffle();
            RedrawList(1);
        }

        private void resetDesk2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            ResetDesk(2);
            RedrawList(2);
        }

        private void shuffleDesk2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            desk2.Shuffle();
            RedrawList(2);
        }

        private void move1To2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                MessageBox.Show("No card was chosen");
            else
            {
                Card temp = desk1.Deal(listBox1.SelectedIndex);
                desk2.Add(temp);
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                RedrawList(1);
                RedrawList(2);
            }
        }

        private void move2To1_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == -1)
                MessageBox.Show("No card was chosen");
            else
            {
                Card temp = desk2.Deal(listBox2.SelectedIndex);
                desk1.Add(temp);
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                RedrawList(1);
                RedrawList(2);
            }
        }
    }
}
