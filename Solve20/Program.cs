using System;

namespace Solve20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Second Number");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a - b;
            if (c < 0)
            {
                c = Math.Abs(c);
                Console.WriteLine("The Absoulate VAlue IS {0}", c);
            }
            else
            {
                Console.WriteLine("The Value is {0}",c * 2);
            }
            Console.ReadKey();
        }
    }
}
