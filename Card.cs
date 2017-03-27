using System;

namespace blackjack{
    public class Card{
        private Suit suit;
        private Face face;

        public Face getFace(){
            return face;
        }

        public Card(Suit suit, Face face){
            this.suit = suit;
            this.face = face;
        }

        public enum Suit
        {
            Heart,
            Diamond,
            Spade,
            Club
        }

        public enum Face
        {
            Ace,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
        }

    }
 
}

