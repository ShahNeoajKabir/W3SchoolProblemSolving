using System;

namespace Solve15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Provlem Solving 15
            //Remove Method
            string a = "W3Resource";
            string b = a.Remove(1, 1);
            string c = a.Remove(8, 1);
            string d = a.Remove(0, 1);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            //Insert & Replace Method
            //Problem Solving 16
            string e = "W3RESOURCE";
            string f = "PYTHON";
            string g = f.Replace('P', 'N').Remove(5, 1).Insert(5,"P");
            string h = e.Remove(0, 1).Remove(8, 1).Insert(8, "W");
            Console.WriteLine("Replace method is {0}", h);
            Console.WriteLine("Replace method is {0}", g);
            //Provlem Solving 17
            string i = "The quick brown fox jumps over the lazy dog.";
            string j = i.Insert(0, "T").Insert(45, "T");
            Console.WriteLine(j);
            Console.ReadKey();

            
        }
    }
}
