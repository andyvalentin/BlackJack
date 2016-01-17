using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Card
    {
        public int NumValue { get; set; }
        public string Suit { get; set; }
        public string Face { get; set; }
    }

    class Deck
    {
        public List<Card> FullDeck { get; set; }

        public Deck()
        {
            this.FullDeck = new List<Card>();

            this.FullDeck.Add(new Card { NumValue = 1, Suit = "Spades", Face = "Ace" });
            this.FullDeck.Add(new Card { NumValue = 2, Suit = "Spades", Face = "2" });
            this.FullDeck.Add(new Card { NumValue = 3, Suit = "Spades", Face = "3" });
            this.FullDeck.Add(new Card { NumValue = 4, Suit = "Spades", Face = "4" });
            this.FullDeck.Add(new Card { NumValue = 5, Suit = "Spades", Face = "5" });
            this.FullDeck.Add(new Card { NumValue = 5, Suit = "Spades", Face = "6" });
            this.FullDeck.Add(new Card { NumValue = 6, Suit = "Spades", Face = "7" });
            this.FullDeck.Add(new Card { NumValue = 7, Suit = "Spades", Face = "8" });
            this.FullDeck.Add(new Card { NumValue = 8, Suit = "Spades", Face = "8" });
            this.FullDeck.Add(new Card { NumValue = 9, Suit = "Spades", Face = "9" });
            this.FullDeck.Add(new Card { NumValue = 10, Suit = "Spades", Face = "Jack" });
            this.FullDeck.Add(new Card { NumValue = 10, Suit = "Spades", Face = "Queen" });
            this.FullDeck.Add(new Card { NumValue = 10, Suit = "Spades", Face = "King" });

            this.FullDeck.Add(new Card { NumValue = 1, Suit = "Diamonds", Face = "Ace" });
            this.FullDeck.Add(new Card { NumValue = 2, Suit = "Diamonds", Face = "2" });
            this.FullDeck.Add(new Card { NumValue = 3, Suit = "Diamonds", Face = "3" });
            this.FullDeck.Add(new Card { NumValue = 4, Suit = "Diamonds", Face = "4" });
            this.FullDeck.Add(new Card { NumValue = 5, Suit = "Diamonds", Face = "5" });
            this.FullDeck.Add(new Card { NumValue = 5, Suit = "Diamonds", Face = "6" });
            this.FullDeck.Add(new Card { NumValue = 6, Suit = "Diamonds", Face = "7" });
            this.FullDeck.Add(new Card { NumValue = 7, Suit = "Diamonds", Face = "8" });
            this.FullDeck.Add(new Card { NumValue = 8, Suit = "Diamonds", Face = "8" });
            this.FullDeck.Add(new Card { NumValue = 9, Suit = "Diamonds", Face = "9" });
            this.FullDeck.Add(new Card { NumValue = 10, Suit = "Diamonds", Face = "Jack" });
            this.FullDeck.Add(new Card { NumValue = 10, Suit = "Diamonds", Face = "Queen" });
            this.FullDeck.Add(new Card { NumValue = 10, Suit = "Diamonds", Face = "King" });

            this.FullDeck.Add(new Card { NumValue = 1, Suit = "Clubs", Face = "Ace" });
            this.FullDeck.Add(new Card { NumValue = 2, Suit = "Clubs", Face = "2" });
            this.FullDeck.Add(new Card { NumValue = 3, Suit = "Clubs", Face = "3" });
            this.FullDeck.Add(new Card { NumValue = 4, Suit = "Clubs", Face = "4" });
            this.FullDeck.Add(new Card { NumValue = 5, Suit = "Clubs", Face = "5" });
            this.FullDeck.Add(new Card { NumValue = 5, Suit = "Clubs", Face = "6" });
            this.FullDeck.Add(new Card { NumValue = 6, Suit = "Clubs", Face = "7" });
            this.FullDeck.Add(new Card { NumValue = 7, Suit = "Clubs", Face = "8" });
            this.FullDeck.Add(new Card { NumValue = 8, Suit = "Clubs", Face = "8" });
            this.FullDeck.Add(new Card { NumValue = 9, Suit = "Clubs", Face = "9" });
            this.FullDeck.Add(new Card { NumValue = 10, Suit = "Clubs", Face = "Jack" });
            this.FullDeck.Add(new Card { NumValue = 10, Suit = "Clubs", Face = "Queen" });
            this.FullDeck.Add(new Card { NumValue = 10, Suit = "Clubs", Face = "King" });

            this.FullDeck.Add(new Card { NumValue = 1, Suit = "Hearts", Face = "Ace" });
            this.FullDeck.Add(new Card { NumValue = 2, Suit = "Hearts", Face = "2" });
            this.FullDeck.Add(new Card { NumValue = 3, Suit = "Hearts", Face = "3" });
            this.FullDeck.Add(new Card { NumValue = 4, Suit = "Hearts", Face = "4" });
            this.FullDeck.Add(new Card { NumValue = 5, Suit = "Hearts", Face = "5" });
            this.FullDeck.Add(new Card { NumValue = 5, Suit = "Hearts", Face = "6" });
            this.FullDeck.Add(new Card { NumValue = 6, Suit = "Hearts", Face = "7" });
            this.FullDeck.Add(new Card { NumValue = 7, Suit = "Hearts", Face = "8" });
            this.FullDeck.Add(new Card { NumValue = 8, Suit = "Hearts", Face = "8" });
            this.FullDeck.Add(new Card { NumValue = 9, Suit = "Hearts", Face = "9" });
            this.FullDeck.Add(new Card { NumValue = 10, Suit = "Hearts", Face = "Jack" });
            this.FullDeck.Add(new Card { NumValue = 10, Suit = "Hearts", Face = "Queen" });
            this.FullDeck.Add(new Card { NumValue = 10, Suit = "Hearts", Face = "King" });

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
