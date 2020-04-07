using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetGreyHoundGame
{
    public partial class Form1 : Form
    {
        Greyhound[] greyhounds = new Greyhound[4];
        Guy[] guysBetting = new Guy[3];
        Random MyRandomizer;
        public Form1()
        {
            InitializeComponent();
            MyRandomizer = new Random();
            // Match dogPicBox to each Greyhound item
            greyhounds[0] = new Greyhound() {
                MyPicBox = dog1,
                StartingPoint = dog1.Left,
                RaceLength = raceTrack.Width - dog1.Width,
                Randomizer = MyRandomizer
            };
            greyhounds[1] = new Greyhound()
            {
                MyPicBox = dog2,
                StartingPoint = dog2.Left,
                RaceLength = raceTrack.Width - dog2.Width,
                Randomizer = MyRandomizer
            };
            greyhounds[2] = new Greyhound()
            {
                MyPicBox = dog3,
                StartingPoint = dog3.Left,
                RaceLength = raceTrack.Width - dog3.Width,
                Randomizer = MyRandomizer
            };
            greyhounds[3] = new Greyhound()
            {
                MyPicBox = dog4,
                StartingPoint = dog4.Left,
                RaceLength = raceTrack.Width - dog4.Width,
                Randomizer = MyRandomizer
            };
            // Initial 3 guys who will bet the race
            guysBetting[0] = new Guy()
            {
                Name = "Joe",
                Cash = 300,
                MyRadioBtn = joeRadioBtn,
                MyLabel = joeBetStatus
            };
            guysBetting[1] = new Guy()
            {
                Name = "John",
                Cash = 400,
                MyRadioBtn = johnRadioBtn,
                MyLabel = johnBetStatus
            };
            guysBetting[2] = new Guy()
            {
                Name = "Al",
                Cash = 600,
                MyRadioBtn = alRadioBtn,
                MyLabel = alBetStatus
            };
            // Show cash and bet burks
            for (int i = 0; i < 3; i++)
                guysBetting[i].UpdateLabel();
            // Min bet
            betMinLabel.Text = "You must bet at least " + burkToBet.Minimum;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
                if (greyhounds[i].Run())
                {
                    timer1.Stop();
                    MessageBox.Show("Dog #" + (i + 1) + " is the winner!");
                    for (int j = 0; j < 3; j++)
                    {
                        guysBetting[j].Collect(i);
                        guysBetting[j].UpdateLabel();
                    }

                    break;
                }
            if (timer1.Enabled == false)
            {
                groupBox1.Enabled = true;
                for (int j = 0; j < 4; j++)
                    greyhounds[j].TakeStartingPoint();
                for (int i = 0; i < 3; i++)
                    guysBetting[i].ClearBet();
            }            
        }

        private void raceBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            groupBox1.Enabled = false;
        }

        private void joeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            bettorLabel.Text = "Joe";
        }

        private void johnRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            bettorLabel.Text = "John";
        }

        private void alRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            bettorLabel.Text = "Al";
        }

        private void betBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                if (guysBetting[i].MyRadioBtn.Checked)
                {
                    guysBetting[i].PlaceBet((int)burkToBet.Value, (int)dogToBet.Value);
                    guysBetting[i].UpdateLabel();
                }
            }
        }
    }
}
