using System;

namespace FizzBuzzGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var calculator = new FizzBuzzKata();
            var stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();

            for (int i = 1; i <= 1000; i++)
            {
                Console.WriteLine(calculator.Answer(i));
            }

            stopWatch.Stop();
            Console.WriteLine($"Elapsed Time: {stopWatch.ElapsedMilliseconds}.");

            Console.WriteLine("Pres any key to continue.");
            Console.ReadKey();
        }
    }
}