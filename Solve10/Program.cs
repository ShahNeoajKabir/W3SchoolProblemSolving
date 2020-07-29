using System;

namespace Solve10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Number: ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Second Number :");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third Number :");
            double c = Convert.ToInt32(Console.ReadLine());
            double sum = a + b + c;
            double div = (a + b) / (b * c);
            double mul = (a * b) + (b * c);
            Console.WriteLine("the sum = {0} the div ={1} the multiplication = {2}", sum, div, mul);
            Console.ReadKey();
        }
    }
}
