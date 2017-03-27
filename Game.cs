using System;
 
namespace blackjack{
    class Game{
        public void start(){
            Deck deck  = new Deck();
            Player person = new Player();
            Player computer = new Player();
            deck.shuffle();           
                         
            while(true){
                bool ifPersonFetchMore = true;
                bool ifComputerFetchMore = true;
                
                //ifPersonFetchMore = this.ifPersonFetchMore();

                while(ifPersonFetchMore == true || ifComputerFetchMore == true){
                    ifPersonFetchMore = this.ifPersonFetchMore();
                    if(ifPersonFetchMore){
                        person.fecthCard(deck.drawACard());
                    }
                    ifComputerFetchMore = this.ifComputerFetchMore();
                    if(ifComputerFetchMore){
                        computer.fecthCard(deck.drawACard());
                    }
                }
                int personSum = person.calculate();
                    int computerSum = computer.calculate();
                    if(personSum > computerSum){
                        Console.WriteLine("Player won");
                        return;
                    }else if(personSum < computerSum){
                        Console.WriteLine("Computer won");
                        return;
                    }else{
                        Console.WriteLine("Tie");
                        return;
                    }
                // while(ifPersonFetchMore) {
                //     person.fecthCard(deck.drawACard());
                //     ifPersonFetchMore = this.ifPersonFetchMore();
                // }

                // ifComputerFetchMore = this.ifComputerFetchMore();
                
                // while (ifComputerFetchMore){
                //     computer.fecthCard(deck.drawACard());
                //     ifComputerFetchMore = this.ifComputerFetchMore();     
                // }

                // if(ifPersonFetchMore == false && ifComputerFetchMore == false){
                //     int personSum = person.calculate();
                //     int computerSum = computer.calculate();
                //     if(personSum > computerSum){
                //         Console.WriteLine("Player won");
                //         return;
                //     }else if(personSum < computerSum){
                //         Console.WriteLine("Computer won");
                //         return;
                //     }else{
                //         Console.WriteLine("Tie");
                //         return;
                //     }
                // }

            }
           

        }
         
        public bool ifComputerFetchMore(){
            return new Random().Next(2) == 1 ? true : false;
        }
        public bool ifPersonFetchMore(){
            while(true){
                Console.WriteLine("Please choose hit or stand");
                Console.WriteLine("Y or N");
                int resultOfIfFetchMore = Console.Read();
                if(resultOfIfFetchMore == (int)'Y'){
                    return true;
                }else if(resultOfIfFetchMore == (int)'Y'){
                    return false;
                }
            }
        }
        
        
    }
}