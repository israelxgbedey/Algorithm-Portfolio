using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CardGame


{
   
class Program
{



    static List<int> StartDeck()
        {
            List<int> deck = new List<int>();
            for (int i = 1; i <= 52; i++)
            {
                deck.Add(i);
            }
            return deck;
        }

   public static void ShuffleDeck(List<int> deck)
        {
            Random rng = new Random();
            for (int i = deck.Count - 1; i > 0; i--)
            {
                // Pick a random index between 0 and i
                int j = rng.Next(i + 1);

                // Swap cards i and j
                int temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }
        }
              static void DistributeDeck(List<int> deck, List<int> player1Deck, List<int> player2Deck)
        {
            for (int i = 0; i < deck.Count; i++)
            {
                if (i % 2 == 0)
                    player1Deck.Add(deck[i]);
                else
                    player2Deck.Add(deck[i]);
            }
        }

    static void Main(string[] args)
    {

        List<int> deck = StartDeck();

        ShuffleDeck(deck);
        Console.WriteLine("Deck shufled.");
         
         List<int> player1Deck = new List<int>();
         List<int> player2Deck = new List<int>();
         DistributeDeck(deck, player1Deck, player2Deck);


        List<int> player1GarbagePile = new List<int>();
        List<int> player2GarbagePIle = new List<int>();

        Game.PlayGame(player1Deck,player2Deck, player1GarbagePile, player2GarbagePIle);

    }
    

}







}
