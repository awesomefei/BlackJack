using System;
using static blackjack.Card;

namespace blackjack{
    class ScoreUltil{
        public static int getScore(Card card){           
            if(card.getFace().Equals(Face.Ace)){
                while (true){
                    Console.WriteLine("Please input the value Ace: ");
                    string valueOfAce = Console.ReadLine();
                    if(valueOfAce.Equals("1")){
                        return 1;
                    }else if(valueOfAce.Equals("11")){
                        return 11;
                    }else{
                        Console.WriteLine("Invalid input");
                    }                           
                }
            }
            int faceValue = (int)(card.getFace());
            if( faceValue < 9){
                return faceValue + 1;
            }else{
                return 10;
            }
        }
    }
}