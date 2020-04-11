using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcPartyFeeVer2
{
    class DinnerParty : Party
    {
        private bool healthyOption;

        public bool HealthyOption { get { return healthyOption; } set { healthyOption = value; } }
        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                totalCost += (decimal)numOfPeople * (this.CalcBeveragePerPersonCost() + 25M);
                if (healthyOption)
                    return 0.95M * totalCost;
                return totalCost;
            }
        }

        public DinnerParty(int numOfPeople, bool fancyDecoration, bool healthyOption)
        {
            this.numOfPeople = numOfPeople;
            this.fancyDecorations = fancyDecoration;
            this.healthyOption = healthyOption;
        }
        private decimal CalcBeveragePerPersonCost()
        {
            if (healthyOption)
                return 5M;
            return 20M;
        }
    }
}
