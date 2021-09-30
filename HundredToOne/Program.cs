using System;

namespace HundredToOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis arve 100 kuni 1
            //kasutame for-loop'i
            //i-- = i - 1

            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}
