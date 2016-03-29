using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Deck
    {
        Card[] cards = new Card[52];
        int index = 0;

        public Deck()
        {
            GenerateCards();
            ShuffleCards();
        }

        public bool DeckIsNotEmpty() {
            return (index < 52);
        }

        //Returns the top card. Stores the default card in former top index of the cards array,
        //and the next card in the deck becomes the top card. If the deck is empty, prints
        //an error message and returns the default card instead.
        public Card TakeTopCard()
        {
            Card topCard;
            Card defaultCard = new Card(Card.Suit.Default,Card.FaceValue.Default);
            try
            {
                topCard = cards[index];
                cards[index] = defaultCard;
                index++;
                return topCard;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Deck is Empty. Default Card Returned.");
                return defaultCard;
            }

        }


        public void ShuffleCards()
        {
            Card[] temp = new Card[52];
            Random random = new Random();
            int current = random.Next(52);

            for (int i = 0; i < 52; i++)
            {
                if (temp[current] == null)
                    temp[current] = cards[i];
                else
                    i--;//retry this index until the card is successfully placed.
                current = random.Next(52);
            }
            //copy temp over to the original card list
                for (int i=0;i<52;i++)
                    cards[i] = temp[i];
        }

        private void GenerateCards()
        {
            int cardIndex = 0;
            for (int suit = 0; suit < 4; suit++)           
                for (int value = 0; value < 13; value++)
                {
                    Card card = new Card(suit, value);
                    cards[cardIndex] = card;
                    cardIndex++;
                }        
        }



    }
}
