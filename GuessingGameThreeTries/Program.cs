using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //prog genereerib juhusliku nri 1 kuni 10
            //kasutaja peab selle nri ära arvama
            //kui kasutaja suutis selle nri ära arvata, siis on ta mängu võitnud
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega nrit ära arvata
            //siis mängu võidab arvuti
            //*prog genereerib juhusliku nri ühe korra

            Random rnd = new Random();
            int RandomNumber = rnd.Next(1, 11);

            int i = 0;

            while (i < 3) // 3 < 3 --> false
            {

                Console.WriteLine("Guess random number from 1 to 10 to win the game.");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (RandomNumber != userGuess)
                {
                    i = i + 1;
                    if (i < 3)
                    {
                        Console.WriteLine($"Try again. {3 - i} tries left.");
                    }
                    else
                    {
                        Console.WriteLine("Computer has won!");
                    }
                }
                else
                {
                    Console.WriteLine("Congrats, you win!");
                    i = 3;
                }

            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
