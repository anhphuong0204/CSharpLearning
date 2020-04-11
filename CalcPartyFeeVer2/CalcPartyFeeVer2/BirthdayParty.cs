using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcPartyFeeVer2
{
    class BirthdayParty : Party
    {
        private string cakeWriting;

        // property
        public string CakeWriting { get { return cakeWriting; } set { cakeWriting = value; } }
        private int ActualLength
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return MaxWritingLength();
                return CakeWriting.Length;
            }
        }

        // method
        public bool CakeWritingTooLong
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return true;
                return false;
            }

        }
        public BirthdayParty(int numOfPeople, bool fancyDecorations, string cakeWriting)
        {
            this.numOfPeople = numOfPeople;
            this.fancyDecorations = fancyDecorations;
            this.cakeWriting = cakeWriting;
        }
        private int CakeSize()
        {
            if (numOfPeople <= 4)
                return 8;
            return 16;
        }
        private int MaxWritingLength()
        {
            if (CakeSize() == 8)
                return 16;
            return 40;
        }
        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                if (CakeSize() == 8)
                    totalCost += 40M + ActualLength * .25M;
                else
                    totalCost += 75M + ActualLength * .25M;
                return totalCost;
            }
        }
    }
}
