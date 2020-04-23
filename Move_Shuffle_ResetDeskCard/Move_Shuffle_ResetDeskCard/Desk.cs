using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Move_Shuffle_ResetDeskCard
{
    class Desk
    {
        private List<Card> cards;
        private Random random = new Random();

        public Desk()
        {
            cards = new List<Card>();
            for (int suit = 0; suit < 4; suit++)
                for (int value = 1; value < 14; value++)
                    cards.Add(new Card((Suits)suit, (Values)value));
        }
        public Desk(IEnumerable<Card> initialCards)
        {
            cards = new List<Card>(initialCards);
        }
        
        public int Count { get { return cards.Count; } }
        public void Add(Card card)
        {
            cards.Add(card);
        }
        public Card Deal(int index)
        {
            Card cardToDeal = cards[index];
            cards.RemoveAt(index);
            return cardToDeal;
        }
        public void Shuffle()
        {
            for (int i = 0; i < cards.Count; i++)
            {
                int rdPos = random.Next(0, cards.Count - 1);
                Card temp = cards[i];
                cards[i] = cards[rdPos];
                cards[rdPos] = temp;
            }
        }
        public IEnumerable<string> GetCardNames()
        {
            string[] nameArray = new string[cards.Count];
            for (int i = 0; i < cards.Count; i++)
                nameArray[i] = cards[i].ToString();
            return nameArray;

        }
        public void Sort()
        {
            cards.Sort(new CardComparer_BySuit());
        }
    }
}
