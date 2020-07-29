using System;

namespace Solve25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                    
                }
            }
            Console.ReadKey();
        }
    }
}
