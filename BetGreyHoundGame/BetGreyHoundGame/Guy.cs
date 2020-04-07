using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetGreyHoundGame
{
    class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadioBtn;
        public Label MyLabel;

        public void UpdateLabel()
        {
            // 1. Set bet on label
            if (MyBet == null)
                MyLabel.Text = Name + " hasn\'t placed a bet";
            else
            {
                MyLabel.Text = MyBet.GetDescription(); 
            }
            // 2. Show my cash on radioBtn
            MyRadioBtn.Text = Name + " has " + Cash + " burks";
        }
        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            // Place a new bet and store it in bet field
            // Return false if dont have enough bucks
            if (BetAmount > Cash)
                return false;
            MyBet = new Bet()
            {
                Amount = BetAmount,
                Bettor = this,
                Dog = DogToWin
            };
            return true;
        }
        public void Collect(int Winner)
        {
            if (MyBet == null)
                return;
            Cash += MyBet.PayOut(Winner);
            ClearBet();
        }
        public void ClearBet()
        {
            // Reset bet = 0
            MyBet = null;
        }
    }
}
