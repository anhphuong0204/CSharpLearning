using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetGreyHoundGame
{
    class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            // Return "One bet..." or "One hasn't bet"
            if (Amount == 0)
                return Bettor.Name + " hasn\'t placed a bet";
            return Bettor.Name + " has bet " + Amount + " on dog #" + Dog;
        }
        public int PayOut(int Winner)
        {
            if (Winner == Dog)
                return Amount;
            return -Amount;
        }
    }
}
