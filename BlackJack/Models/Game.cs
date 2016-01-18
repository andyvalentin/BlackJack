using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Models
{
    class Game
    {
        private Player p1 = new Player();
        private Player dealer = new Player();

        //
        //Begins the game, sets the cardsum of each player to 0 and deals first 3 cards.  2 to player and 1 to dealer
        public void DealCards()
        {
            var FD = new Deck().FullDeck;
            FD.Shuffle();
            p1.CardSum = 0;
            dealer.CardSum = 0;

            Console.WriteLine("WELCOME TO BLACKJACK \nPlease hit y or n then enter to answer questions");
            Console.WriteLine("\nYou have been dealt two cards:");
            Console.WriteLine("\n{0}<{1}> || {2}<{3}>", FD[0].Face, FD[0].Suit, FD[1].Face, FD[1].Suit);


            if (FD[0].NumValue == 10 && FD[1].Face == "Ace" || FD[0].Face == "Ace" && FD[1].NumValue == 10)
            {
                Console.WriteLine("\nBlackJack!!! You WIN!!");
                return;
            }
            else if (FD[0].Face == "Ace")
            {
                Console.WriteLine("\nYour first card is an Ace. Would you like this Ace to be worth 11?");


                if (Console.ReadLine() == "y")
                {
                    FD[0].NumValue = 11;

                }
            }
            else if (FD[1].Face == "Ace")
            {
                Console.WriteLine("\nYour second card is an Ace. Would you like this Ace to be worth 11?");


                if (Console.ReadLine() == "y")
                {
                    FD[1].NumValue = 11;
                }
            }

            p1.CardSum = FD[0].NumValue + FD[1].NumValue;
            Console.WriteLine("Total Score: {0}", p1.CardSum);


            Console.WriteLine("\nThe dealer is showing:");
            Console.WriteLine("{0}({1})", FD[3].Face, FD[3].Suit);
            dealer.CardSum = FD[3].NumValue;

            Hit(FD, 4);
        }

        //
        //Asks the player to hit and adds card to cound check for blackjack, win or bust.  If user answer no then begins dealers turn
        private void Hit(List<Card> temp, int val)
        {
            var deck = temp[val];

            Console.WriteLine();
            Console.WriteLine("\nWould you like to hit?");
            string response = Console.ReadLine();

            if (response == "y")
            {
                Console.WriteLine("{0}({1})", deck.Face, deck.Suit);

                if (deck.Face == "Ace")
                {
                    Console.WriteLine("\nYour dealt card is an Ace. Would you like this Ace to be worth 11?");

                    if (Console.ReadLine() == "y")
                    {
                        deck.NumValue = 11;
                    }
                }

                p1.CardSum += deck.NumValue;

                if (p1.CardSum > 21)
                {
                    Console.WriteLine("\nYou BUSTED!, YOU LOSE!. Score is {0}", p1.CardSum);
                    Replay();
                }

                else if (p1.CardSum == 21)
                {
                    Console.WriteLine("\nBlackJack!!! You WIN!!");
                    Replay();
                }
                else
                {
                    Console.WriteLine("\nTotal Score: {0}", p1.CardSum);
                    Hit(temp, val += 1);
                }
            }


            if (response == "n")
            {
                DealerTurn(temp, val);
            }
        }


        //
        //This begins the dealers turn on the player has stopped hitting. Checks for dealer cardsum against player and for dealer bust and blackjack
        private void DealerTurn(List<Card> temp, int val)
        {
            var deck = temp[val];
            dealer.CardSum += deck.NumValue;
            Console.WriteLine("\nDealer was delt a: {0}({1})", deck.Face, deck.Suit);
            Console.WriteLine("Dealer total is: {0}", dealer.CardSum);

            if (dealer.CardSum < 17)
            {
                DealerTurn(temp, val += 1);
            }
            else if (dealer.CardSum > 21)
            {
                Console.WriteLine("\nThe dealer busted.  You WIN!!!");
                Replay();
            }
            else if (dealer.CardSum <= 21 && dealer.CardSum >= 17)
            {
                if (dealer.CardSum >= p1.CardSum)
                {
                    Console.WriteLine("\nYOU LOSE!");
                    Replay();

                }
                else if (p1.CardSum > dealer.CardSum)
                {
                    Console.WriteLine("\nHooray, you WIN!!!!!!");
                    Replay();
                }
            }
        }

        private void Replay()
        {
            Console.WriteLine("\nWould you like to play another hand?");
            var reponse = Console.ReadLine();
            if (reponse == "y")
            {
                Console.WriteLine();
                DealCards();
            }
            else if(reponse == "n")
            {
                return;
            }
            else
            {
                Console.WriteLine("\nInvalid response. Please enter y or n then enter");
                Replay();
            }
        }

    }
}
