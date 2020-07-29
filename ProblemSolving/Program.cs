using System;

namespace ProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello: I'm Bappy");
            int a = 20;
            int b = 30;
            float c = a + b;
            double d = c / a;
            Console.WriteLine(c);
            Console.WriteLine(d);
            //problem solving 5
            int e = 10;
            int f = 20;
            int temp = e;
            e = f;
            f = temp;
            Console.WriteLine("the first number is {0} and the second Number is {1}", e, f);
            // Problem solving 6
            Console.WriteLine("Enter the first  number");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second  number");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third  number");
            int ThirdNumber = Convert.ToInt32(Console.ReadLine());
            int result = FirstNumber * SecondNumber * ThirdNumber;
            Console.WriteLine("the result is {0}", result);
            //problem solving 7
            int Seven = 25;
            int two = 4;
            int sum = Seven + two;
            int sub = Seven - two;
            int mul = Seven * two;
            int div = Seven / two;
            int mod = Seven % two;
            Console.WriteLine("the sum is {0} the sub is {1} the multiplication is {2} the division is {3} the mod is {4}", sum, sub, mul, div, mod);
            //problem solving 9 && also array average valu 
            int[] Avg = { 10, 20, 40, 30, 50, 60 };
            int n = Avg.Length;
            float Sum = 0;
            float avg;
            for (int i = 0; i < n; i++)
            {
                Sum += Avg[i];
                Console.WriteLine("Sum Is {0}",Sum);
            }
            avg = Sum / n;
            Console.WriteLine(avg);
            // problem solving 8
            int N = 10;
            int O;
            int P;
            for (O = 0; O <= N; O++)
            {
                P = 5 * O;
                Console.WriteLine("The Value is 5 * {0} = {1}", O, P);


            }
            
            Console.ReadKey();
        }
    }
}
