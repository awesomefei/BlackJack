using System.Collections.Generic;
using System;

namespace blackjack{
    class Player{
        private string name;
        public int sum = 0;
        private List<Card> holdCards;
        
        public Player(){
            holdCards = new List<Card>();
        }

        public void fecthCard(Card card){
            holdCards.Add(card);
        }

        public int calculate(){
            sum = 0;
            foreach(Card card in holdCards){
                sum += ScoreUltil.getScore(card);
            }
            if(sum > 21){
                Console.WriteLine("You Lose");
                return -1;
            }
            return sum;
        }

       
    }

}