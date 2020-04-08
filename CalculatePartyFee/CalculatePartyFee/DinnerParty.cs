using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatePartyFee
{
    class DinnerParty
    {
        private int NumOfPeople;
        public decimal CostOfBeveragePerPerson;
        public decimal CostOfDecoration;
        public const int CostOfFoodPerPerson = 25;

        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
                CostOfBeveragePerPerson = 5M;
            else
                CostOfBeveragePerPerson = 20M;
        }
        private void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
                CostOfDecoration = 15 * (decimal)NumOfPeople + 50;
            else
                CostOfDecoration = 7.5M * (decimal)NumOfPeople + 30;
        }
        public void SetPartyOption(int people, bool fancy)
        {
            NumOfPeople = people;
            CalculateCostOfDecorations(fancy);
        }
        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalFee = (decimal)NumOfPeople * ((decimal)CostOfFoodPerPerson + CostOfBeveragePerPerson) + CostOfDecoration;
            if (healthyOption)
                return totalFee * 0.95M;
            return totalFee;
        }
    }
}
