using System;

namespace PrimeNumbersOneToOneHundred
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersPrinted = 0;

            for (int numberToCheck = 2; numberToCheck < 1000; numberToCheck++)
            {
                bool isPrime = true;

                for (int y = 2; y < numberToCheck; y++)
                {
                    if ((numberToCheck % y) == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime && numbersPrinted < 100)
                {
                    numbersPrinted++;
                    Console.WriteLine($"{numbersPrinted}. {numberToCheck}");
                    
                }
            }
        }
    }
}
