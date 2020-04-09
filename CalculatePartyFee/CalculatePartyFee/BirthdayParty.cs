using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatePartyFee
{
    class BirthdayParty
    {
        private int numOfPeople;
        private bool fancyDecorations;
        private string cakeWriting;
        private const int costOfFoodPerPerson = 25;
        
        public int NumOfPeople { get { return numOfPeople; } set { numOfPeople = value; } }
        public bool FancyDecorations { get { return fancyDecorations; } set { fancyDecorations = value; } }
        public string CakeWriting { 
            get { return cakeWriting; } 
            set {
                cakeWriting = value;
            }
        }
        private int ActualLength { 
            get {
                if (CakeWriting.Length > MaxWritingLength())
                    return MaxWritingLength();
                return CakeWriting.Length;
            }
        }
        public bool CakeWritingTooLong
        {
            get {
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

        private decimal CalcDecorationCost()
        {
            if (fancyDecorations)
                return numOfPeople * 15M + 50M;
            return numOfPeople * 7.5M + 30M;
        }
        public decimal Cost { 
            get {
                return numOfPeople * costOfFoodPerPerson + ((CakeSize() == 8) ? 40M + ActualLength * .25M : 75M + ActualLength * .25M) + CalcDecorationCost();
                                                                                // Small cake               // Big cake
            }
        }
    }
}
