using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardWithOverloadMethods
{
    class Program
    {
        public static bool DoesCardMatch(Card card, Values value)
        {
            if (card.Value == value)
                return true;
            return false;
        }

        public static bool DoesCardMatch(Card card, Suits suit)
        {
            if (card.Suit == suit)
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            Card card = new Card(Suits.Hearts, Values.King);
            bool doesItMatch = DoesCardMatch(card, Suits.Hearts);
            Console.WriteLine(doesItMatch);
            Console.ReadKey();
        }
    }
}
