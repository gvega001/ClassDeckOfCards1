using System;

namespace online.dev4you
{
    class DeckOfCardsTest
    {
        static void Main()
        {
            DeckOfCards myDeckOfCards = new DeckOfCards();
            myDeckOfCards.Shuffle(); // Place the cards in random order

            //display all the cards. Should deal 52 totals
            for (int i = 0; i < 50; ++i)
            {
                Console.WriteLine($"{myDeckOfCards.DealCard(),-19}");
                if ((i + 1)% 4 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
