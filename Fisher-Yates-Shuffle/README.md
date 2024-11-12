# War Card Game (Console Application)

## Overview
This console application simulates the card game "War." Two players are dealt half a deck each. They play by comparing the top card of their deck, and the player with the higher card wins both cards and puts them in their garbage pile. When a player runs out of cards in their deck, the garbage pile is shuffled and used as their new deck.

## Fisher-Yates Shuffle
The Fisher-Yates shuffle algorithm is used to randomly shuffle the deck of cards. It works by iterating over the array of cards and, for each element, swapping it with a randomly chosen element from the remaining unshuffled portion. This ensures that every possible ordering of the deck is equally probable, resulting in a fair and unbiased shuffle.

### How the Fisher-Yates Shuffle is Implemented
In the code, the `ShuffleDeck` method demonstrates the Fisher-Yates shuffle. We traverse the deck from the last card to the first, swapping each card with another randomly selected card from the remaining unshuffled portion.

## Game Flow
- The deck is initialized and shuffled using the Fisher-Yates algorithm.
- The deck is split between two players.
- Players take turns drawing cards and comparing their values. The winner of each round adds the cards to their garbage pile.
- If a player's deck is empty, the garbage pile is shuffled and used as the new deck.
- The game continues until one player has no cards left.

## How to Run
Clone this repository and run the console application.

