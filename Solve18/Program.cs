using System;

namespace Solve18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second Number");
            int b = Convert.ToInt32(Console.ReadLine());
            if(a<0 && b > 0)
            {
                Console.WriteLine("True");
            }
            else if(a>0 && b < 0)
            {
                Console.WriteLine("True");
            }
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
