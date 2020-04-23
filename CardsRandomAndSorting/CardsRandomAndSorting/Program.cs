using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsRandomAndSorting
{
    class Program
    {
        static void PrintCards(List<Card> cards)
        {
            for (int i = 0; i < cards.Count; i++)
                Console.WriteLine(cards[i].Name);
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            List<Card> cards = new List<Card>();
            for (int i = 0; i < 5; i++)
                cards.Add(new Card((Suits)random.Next(4), (Values)random.Next(1, 14)));
            Console.WriteLine("5 random cards:");
            PrintCards(cards);

            cards.Sort(new CardComparer_ByValue());
            Console.WriteLine("5 random cards, sorted by value:");
            PrintCards(cards);
            Console.ReadKey();
        }
    }
}
