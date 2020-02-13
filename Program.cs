using System;
using System.Collections.Generic;
namespace DeckShuffler
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome! I am shuffling cards.");
      // Group the suits and ranks
      var unShuffled = new List<string>
      {
            "Ace of Spades",
            "Two of Spades",
            "Three of Spades",
            "Four of Spades",
            "Five of Spades",
            "Six of Spades",
            "Seven of Spades",
            "Eight of Spades",
            "Nine of Spades",
            "Ten of Spades",
            "Jack of Spades",
            "Queen of Spades",
            "King of Spades",
            "Ace of Clubs",
            "Two of Clubs",
            "Three of Clubs",
            "Four of Clubs",
            "Five of Clubs",
            "Six of Clubs",
            "Seven of Clubs",
            "Eight of Clubs",
            "Nine of Clubs",
            "Ten of Clubs",
            "Jack of Clubs",
            "Queen of Clubs",
            "King of Clubs",
            "Ace of Hearts",
            "Two of Hearts",
            "Three of Hearts",
            "Four of Hearts",
            "Five of Hearts",
            "Six of Hearts",
            "Seven of Hearts",
            "Eight of Hearts",
            "Nine of Hearts",
            "Ten of Hearts",
            "Jack of Hearts",
            "Queen of Hearts",
            "King of Hearts",
            "Ace of Diamonds",
            "Two of Diamonds",
            "Three of Diamonds",
            "Four of Diamonds",
            "Five of Diamonds",
            "Six of Diamonds",
            "Seven of Diamonds",
            "Eight of Diamonds",
            "Nine of Diamonds",
            "Ten of Diamonds",
            "Jack of Diamonds",
            "Queen of Diamonds",
            "King of Diamonds",
            };
      // shuffle
      Console.WriteLine("Thhhhwap");
      Random rnd = new Random();
      var notShuffled = 52;
      for (var i = notShuffled - 1; i >= 0; i--)
      {
        var j = rnd.Next(unShuffled.Count);
        var swap = unShuffled[i];
        unShuffled[i] = unShuffled[j];
        unShuffled[j] = swap;
      }
      // Display top card
      {
        int k = 1;
        int n = 0;
        while (k > 0)
        {
          var topCard = unShuffled[0];
          var hand1 = new List<string> { };
          var hand2 = new List<string> { };
          Console.WriteLine("the new dealt card is the " + topCard);
          if (n % 2 == 0)
          {
            hand1.Add(unShuffled[0]);
            // which hand?
            Console.WriteLine("added the following to hand one: " + unShuffled[0]);
            n++;
          }
          else
          {
            hand2.Add(unShuffled[0]);
            Console.WriteLine("added the following to hand two: " + unShuffled[0]);
            n++;
          }
          unShuffled.RemoveAt(0);
          // Ask to play again
          Console.WriteLine("Would you like to play again? Yes or no.");
          var donePlaying = Console.ReadLine();
          if (donePlaying == "no")
          {
            k = k - 1;
            Console.WriteLine("Thanks for playing!");
          }
        }
      }
    }
  }
}