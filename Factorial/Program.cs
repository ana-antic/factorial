using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int f = 1;
            int n;

            Console.Write("Input the number : ");
            n = Convert.ToInt32(Console.ReadLine());

            while (n < 1) 
            {
                Console.Write("Please input the correct number : ");
                n = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = n; i > 0; i--)
                 f *= i;
            
            Console.Write("The Factorial of {0} is: {1}\n", n, f);
        }
    }
}
