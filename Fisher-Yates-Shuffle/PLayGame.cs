using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace CardGame

{
class Game
{


        // Play the game
        public static void PlayGame(List<int> player1Deck, List<int> player2Deck, List<int> player1Garbage, List<int> player2Garbage)
        {
            Random rng = new Random();
            while (player1Deck.Count > 0 && player2Deck.Count > 0)
            {
                // Draw the top card from each player's deck
                int player1Card = player1Deck[0];
                int player2Card = player2Deck[0];
                player1Deck.RemoveAt(0);
                player2Deck.RemoveAt(0);

                Console.WriteLine($"Player 1 plays {player1Card}, Player 2 plays {player2Card}");

                // Compare cards and determine winner
                if (player1Card > player2Card)
                {
                    Console.WriteLine("Player 1 wins the round.");
                    player1Garbage.Add(player1Card);
                    player1Garbage.Add(player2Card);
                }
                else if (player2Card > player1Card)
                {
                    Console.WriteLine("Player 2 wins the round.");
                    player2Garbage.Add(player1Card);
                    player2Garbage.Add(player2Card);
                }
                else
                {
                    Console.WriteLine("It's a tie! No cards awarded.");
                }

                // Check if a player's deck is empty and shuffle their garbage pile if necessary
                if (player1Deck.Count == 0 && player1Garbage.Count > 0)
                {
                    Console.WriteLine("Player 1's deck is empty. Shuffling garbage pile into new deck.");
                    Program.ShuffleDeck(player1Garbage);
                    player1Deck.AddRange(player1Garbage);
                    player1Garbage.Clear();
                }
                if (player2Deck.Count == 0 && player2Garbage.Count > 0)
                {
                    Console.WriteLine("Player 2's deck is empty. Shuffling garbage pile into new deck.");
                    Program.ShuffleDeck(player2Garbage);
                    player2Deck.AddRange(player2Garbage);
                    player2Garbage.Clear();
                }
            }

            // Determine the winner
            if (player1Deck.Count > 0)
            {
                Console.WriteLine("Player 1 wins the game!");
            }
            else
            {
                Console.WriteLine("Player 2 wins the game!");
            }
        }
    }
}




