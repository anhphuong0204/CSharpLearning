using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatePartyFee
{
    class DinnerParty
    {
        private int numOfPeople;
        private bool fancyDecoration;
        private bool healthyOption;

        public int NumOfPeople { get { return numOfPeople; } set { numOfPeople = value; } }
        public bool FancyDecoration { get { return fancyDecoration; } set { fancyDecoration = value; } }
        public bool HealthyOption { get { return healthyOption; } set { healthyOption = value; } }
        public decimal Cost { get {
                decimal totalCost;
                totalCost = this.CalcDecorationCost() + (decimal)numOfPeople * (this.CalcBeveragePerPersonCost() + 25M);
                if (healthyOption)
                    return 0.95M * totalCost;
                return totalCost;
            } }

        public DinnerParty(int numOfPeople, bool fancyDecoration, bool healthyOption)
        {
            this.numOfPeople = numOfPeople;
            this.fancyDecoration = fancyDecoration;
            this.healthyOption = healthyOption;
        }
        private decimal CalcDecorationCost()
        {
            if (fancyDecoration)
                return (decimal)numOfPeople * 15M + 50M;
            return (decimal)numOfPeople * 7.5M + 30M;
        }
        private decimal CalcBeveragePerPersonCost()
        {
            if (healthyOption)
                return 5M;
            return 20M;
        }
    }
}
