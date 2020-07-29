using System;

namespace Solve9
{
    class Program
    {
        static void Main(string[] args)
        {
            // the avg of number 
            Console.WriteLine("Enter the First Number: ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Second Number :");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third Number :");
            double c = Convert.ToInt32(Console.ReadLine());
            double avg = (a + b + c) / 3;
            Console.WriteLine("the average of {0},{1},{2} is = {3}", a, b, c, avg);
            Console.ReadKey();
        }
    }
}
