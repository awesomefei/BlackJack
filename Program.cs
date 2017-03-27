using System;

namespace blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rdm = new Random();
            for(int i=0; i< 100; i++){
                Console.WriteLine(rdm.Next(2));
            }
        }
    }
}
