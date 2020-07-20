using System;

namespace online.dev4you
{
	class DeckOfCards
	{
		// deal one Card
		public Card DealCard()
		{
	
			//determine wheter Cards remain to be dealt
			if (currentCard < deck.Length)
			{
				//return current Card in array
				return deck[currentCard++];
			}
			else
			{
				//indicate that all Cards were dealt
				return null;
			}
		}
		//create one Random object to share among DeckOfCards object
		private static Random randomNumbers = new Random();

		//number of cards in a deck
		private const int NumberOfCards = 51;
		private Card[] deck = new Card[NumberOfCards];
		//index of next Card to be dealt(0-51)
		private int currentCard = 0;
		public DeckOfCards()
		{
			string[] faces = { "Ace", "Deuce", "Three", "Four", "Four", "Five" , "Six",
			"Seven", "Eight", "Nine", "Queen", "King" };
			string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

			for (var count = 0; count <= deck.Length; ++count)
			{
                try
                {
					deck[count] = new Card(faces[count % 13], suits[count / 13]);
				}
                catch (IndexOutOfRangeException)
                {
					
                    //////throw;
                } 
				
			}
		}
		public void Shuffle()
		{
			//after shuffling, dealing should star at deck[0] again
			currentCard = 0;

			//for each Card, pick another random card and swap them
			for (var first = 0; first < deck.Length; ++first)
			{
				// select a random number between 0 to 51
				var second = randomNumbers.Next(NumberOfCards);

				//swap current Card with randomly slected Card
				Card temp = deck[first];
				deck[first] = deck[second];
				deck[second] = temp;
			}
		}

	}
}