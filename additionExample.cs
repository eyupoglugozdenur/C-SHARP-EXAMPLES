using System;

namespace AdditionExample
{
    class Program
    {
        //The sum of numbers from 1 to 100
        static void Main(string[] args)
        {
            int i = 1;
            int sum = 0;
            do
            {           
                sum += i;             
                i += 1;

            } while (i<=100);

            Console.WriteLine("Total: "+sum);
            Console.ReadLine();

        }
    }
}
