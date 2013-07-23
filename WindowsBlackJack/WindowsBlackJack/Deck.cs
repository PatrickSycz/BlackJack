using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsBlackJack
{
    public class Deck
    {
        List<Card> Cards;
        string Name;

        public Deck(string _name)
        {
            Cards = new List<Card>();
            Name = _name != null ? _name : "Deck";
            if (Name.Equals("Deck"))
            {
                InitializeDeck();
                Shuffle();
            }

        }
        public void InitializeDeck()
        {
            Card _card;
            string [] NameBySuit = { "Spades", "Hearts", "Diamonds", "Clubs"};
            string extension = ".png";
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    _card = new Card();
                    _card.AddValue(j < 10 ? (j + 1) : 10);
                    if (j == 0)
                        _card.AddValue(11);
                    _card.SetImage(NameBySuit[i] + j.ToString() + extension);
                    Cards.Add(_card);
                }
            }
        }
        public void Shuffle()
        {
            Random r = new Random();
            Card temp;
            int index1, index2;
            for (int i = 0; i < 10000; i++)
            {
                index1 = r.Next(0, 52);
                index2 = r.Next(0, 52);
                temp = Cards[index1];
                Cards[index1] = Cards[index2];
                Cards[index2] = temp;
            }
        }

        public void AddCard(List<Card> _from)
        {
            if (_from.Count > 0)
            {
                Cards.Add(_from[0]);
            }
        }
        public void AddCard(Card _from)
        {
            if(_from != null)
                Cards.Add(_from);
        }
        public void RemoveTopCard()
        {
            if (Cards.Count > 0)
                Cards.RemoveAt(0);
        }
        public List<Card> GetCardList()
        {
            return Cards;
        }

        public int GetTotalHandValue()
        {
            int total = 0;
            List<int> skipped = new List<int>();
            for(int i = 0; i < Cards.Count; i++)
            {
                if (Cards.ElementAt(i).GetValues().Count < 2)
                    total += Cards.ElementAt(i).GetValues().First();
                else
                    skipped.Add(i);
            }
            for (int i = 0; i < skipped.Count; i++)
            {
                if ((total + Cards.ElementAt(skipped.ElementAt(i)).GetValues().Last()) > 21)
                {
                    if ((total + Cards.ElementAt(skipped.ElementAt(i)).GetValues().First()) > 21)
                    {
                        total = -1;
                        return total;
                    }
                    else
                        total += Cards.ElementAt(skipped.ElementAt(i)).GetValues().First();
                }
                else
                    total += Cards.ElementAt(skipped.ElementAt(i)).GetValues().Last();
            }
            return total;
        }
    }
}
