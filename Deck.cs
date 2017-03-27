using System;
using System.Collections.Generic;
using static blackjack.Card;

namespace blackjack{
    class Deck{
        private List<Card> cards;
        //constructor in order
        public Deck(){
            cards = new List<Card>();
            foreach(Suit suit in Enum.GetValues(typeof(Suit))) {
                foreach(Face face in Enum.GetValues(typeof(Face))){
                    cards.Add(new Card(suit, face));
                }
            }
        }
        
        public void shuffle(){
            //Return Value
            //Type: System.Int32
            //A 32-bit signed integer that is greater than or equal to 0, and less than maxValue; that is, the range of return values ordinarily includes 0 but not maxValue. However, if maxValue equals 0, maxValue is returned.
            Random rng = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card card = cards[k];
                cards[k] = cards[n];
                cards[n] = card;
            }
        }

        public Card drawACard(){
            if(cards.Count <= 0){
                throw new Exception("Ties") ;
            }else{
                Card drawACard = cards[0];
                cards.RemoveAt(0);
                return drawACard;
            }
        }
    }
}