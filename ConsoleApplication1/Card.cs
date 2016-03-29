using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Card
    {
        public enum Suit {Hearts,Spades,Clubs,Diamonds,Default};
        public enum FaceValue {Ace,Two,Three,Four,Five,Six,Seven,Eight,Nine,Ten,Jack,Queen,King,Default};

        private Suit cardSuit;
        private FaceValue cardValue;

        public Card(Suit cardSuit,FaceValue cardValue) { 
            this.cardSuit = cardSuit;
            this.cardValue = cardValue;
        }

        public Card(int suit, int value) {
            this.cardSuit = (Suit)suit;
            this.cardValue = (FaceValue)value;
        }

        public Suit CardSuit
        {
            get { return cardSuit; }
        }

        public FaceValue CardValue
        {
            get { return cardValue; }
        }


    }
}
