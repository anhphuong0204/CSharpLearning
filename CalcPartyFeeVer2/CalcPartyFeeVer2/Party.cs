using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcPartyFeeVer2
{
    class Party
    {
        protected int numOfPeople;
        protected bool fancyDecorations;
        private const int costOfFoodPerPerson = 25;

        // property of fields
        public int NumOfPeople { get { return numOfPeople; } set { numOfPeople = value; } }
        public bool FancyDecoration { get { return fancyDecorations; } set { fancyDecorations = value; } }

        // method
        private decimal CalcDecorationCost()
        {
            if (fancyDecorations)
                return numOfPeople * 15M + 50M;
            return numOfPeople * 7.5M + 30M;
        }
        virtual public decimal Cost { 
            get
            {
                decimal totalCost = 0;
                totalCost += (decimal)numOfPeople * (decimal)costOfFoodPerPerson + CalcDecorationCost();
                if (numOfPeople > 12)
                    return totalCost + 100;
                return totalCost;
            }
        }
    }
}
