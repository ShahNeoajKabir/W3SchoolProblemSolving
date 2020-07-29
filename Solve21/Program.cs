using System;

namespace Solve21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Second Number");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            if (a == 20 || b == 20 || sum == 20)
            {
                bool c = true;
                Console.WriteLine("The ans is {0}",c);
            }
            else
            {
                Console.WriteLine("The Sum Is {0}", sum);
            }
            Console.ReadKey();
        }
    }
}
