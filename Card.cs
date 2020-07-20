using System;

namespace online.dev4you
{
    class Card
    {
        private string Face { get; } // Card's face ("Ace", etc..)
        private string Suit { get; } // Card's sut ("Hearts" , etc...)
   
        public Card(string face, string suit)
        {
            Face = face; //initialize face of card
            Suit = suit; //initialize 
        }

        //return string representation of Card
        public override string ToString() => $"{Face} of {Suit }";
    }

}
