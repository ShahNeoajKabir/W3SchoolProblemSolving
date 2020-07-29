using System;

namespace Solve24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String Value");
            string a = Console.ReadLine();
            string[] b = a.Split();
            string c = "";
           int count = 0;
            foreach(String s in b)
            {
                if (s.Length > count)
                {
                    c = s;
                    count = s.Length;

                }

            }
            Console.WriteLine("the largest value is {0}", c);
            Console.ReadKey();
        }
    }
}
