using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetGreyHoundGame
{
    class Greyhound
    {
        public int StartingPoint;
        public int RaceLength;
        public PictureBox MyPicBox;
        public int Location = 0;    //location on the race track
        public Random Randomizer;

        public bool Run()
        {
            // Move forward 1,2,3,4 random
            Location += Randomizer.Next(4);
            // Update position on PicBox: MyPicBox.Left = StartingPoint + Location;
            MyPicBox.Left = StartingPoint + Location;
            // Return true if I won
            if (Location >= RaceLength)
                return true;
            return false;
        }
        public void TakeStartingPoint()
        {
            // Reset location = 0 and PictureBox to start point
            Location = 0;
            MyPicBox.Left = StartingPoint;
        }
    }
}
