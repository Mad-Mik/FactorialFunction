using System;

namespace FactorialFunction
{
    class Program
    {
        //F(n) = n!; 5! = 1 * 2 * 3 * 4 * 5 = 120; F(1) = 1; F(0) = 1;
        static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            int x = Factorial(4);  //24

            Console.WriteLine(x);
            Console.WriteLine(Factorial(5));  //120
            Console.WriteLine(Factorial(6));  //720
            Console.WriteLine(Factorial(7));  //5040
            Console.ReadKey();
        }
    }
}
