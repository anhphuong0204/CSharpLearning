using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFish
{
    class Player
    {
        private string name;
        public string Name { get { return name; } }
        private Random random;
        private Deck cards;
        private TextBox textBoxOnForm;
        public Player(String name, Random random, TextBox textBoxOnForm)
        {
            this.name = name;
            this.random = random;
            cards = new Deck(new Card[] { });
            this.textBoxOnForm = textBoxOnForm;
            textBoxOnForm.Text += name + " has just joined the game\r\n";
        }
        public IEnumerable<Values> PullOutBooks() {
            List<Values> books = new List<Values>();
            for (int i = 1; i <= 13; i++)
            {
                Values value = (Values)i;
                int howMany = 0;
                for (int card = 0; card < cards.Count; card++)
                    if (cards.Peek(card).Value == value)
                        howMany++;
                if (howMany == 4)
                {
                    books.Add(value);
                    cards.PullOutValues(value);
                }
            }
            return books;
        }
        public Values GetRandomValue()
        {
            Card rdCard = cards.Peek(random.Next(cards.Count));
            return rdCard.Value;
        }
        public Deck DoYouHaveAny(Values value)
        {
            Deck deckOfValue = cards.PullOutValues(value);
            textBoxOnForm.Text += name + " has " + deckOfValue.Count + " " + Card.Plural(value) + Environment.NewLine;
            return deckOfValue;
        }
        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            // Here's an overloaded version of AskForACard()—choose a random value
            // from the deck using GetRandomValue() and ask for it using AskForACard()
            if (stock.Count > 0)
            {
                if (cards.Count == 0)
                    cards.Add(stock.Deal());
                AskForACard(players, myIndex, stock, GetRandomValue());
            }
        }
        public void AskForACard(List<Player> players, int myIndex, Deck stock, Values value)
        {
            textBoxOnForm.Text += name + " asks if anyone has a " + value + Environment.NewLine;
            int numbersOfMyCard = cards.Count;
            for (int i = 0; i < players.Count; i++)
            {
                if (i != myIndex)
                {
                    Deck deckToAdd = players[i].DoYouHaveAny(value);
                    while (deckToAdd.Count > 0)
                        cards.Add(deckToAdd.Deal());
                }
            }
            if (numbersOfMyCard == cards.Count && stock.Count > 0)
            {
                textBoxOnForm.Text += name + " must draw a card from stock" + Environment.NewLine;
                cards.Add(stock.Deal());
            }
        }
        // Here's a property and a few short methods that were already written for you
        public int CardCount { get { return cards.Count; } }
        public void TakeCard(Card card) { cards.Add(card); }
        public IEnumerable<string> GetCardNames() { return cards.GetCardNames(); }
        public Card Peek(int cardNumber) { return cards.Peek(cardNumber); }
        public void SortHand() { cards.SortByValue(); }
    }
}
