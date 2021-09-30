using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //prog genereerib juhusliku nri 1 kuni 10
            //kasutaja peab selle nri ära arvama
            //kui kasutaja suutis selle nri ära arvata, siis on ta mängu võitnud
            //katsete arv piiramatu
            //*prog genereerib juhusliku nri ühe korra


            Random rnd = new Random();
            int RandomNumber = rnd.Next(1, 11);

            bool loopActive = true;

            while (loopActive)
            {

                Console.WriteLine("Guess random number from 1 to 10 to win the game.");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (RandomNumber == userGuess)
                {
                    Console.WriteLine("Congats, you win!");
                    loopActive = false;
                }
                else
                {
                    Console.WriteLine("Try again!");
                }

            }
            Console.WriteLine("Kena päeva!");


        }
    }
}
