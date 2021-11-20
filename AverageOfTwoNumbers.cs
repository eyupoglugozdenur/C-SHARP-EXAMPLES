using System;

namespace AverageOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter First Number: ");
            double number1 =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter Second Number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double average=(number1+number2)/2;
            Console.WriteLine("the Average of These Two Numbers Is: "+average);
            Console.ReadLine();

        }
    }
}