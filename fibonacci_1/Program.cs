using System;

namespace fibonacci_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var  x = FibonacciIteration(5);
            Console.WriteLine(x);
            var y = FibonacciRecursion(5);
            Console.WriteLine(y);
            var z = Fibonacci(5);
            Console.WriteLine(z);
            var d = Fibonacci(5L);
            Console.WriteLine(d);
        }

        public static int FibonacciIteration(int number)
        {
            int current = 0;
            int next = 1;
            for (int i = 0; i < number; i++)
            {
                next += current;
                current = next - current;
            }
            return current;
        }

        public static int FibonacciRecursion(int number)
        {
            if (number == 0)
                return 0;
            if (number == 1)
                return 1;
            return FibonacciRecursion(number - 1) + FibonacciRecursion(number - 2);
        }

        public static int  Fibonacci(int n)
        {
            return Fibonacci(n, new int[n + 1]);
        }

        public static int Fibonacci(int i, int[] memo)
        {
            if (i == 0 || i == 1) return i;
            if (memo[i] == 0)
                memo[i] = Fibonacci(i - 1, memo) + Fibonacci(i - 2, memo);
            return memo[i];
        }

        public uint Fibonacci(uint n)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            uint[] memo = new[] {n};
            memo[0] = 0;
            memo[1] = 1;
            for (int i = 2; i < n; i++)
                memo[i] = memo[i - 1] + memo[i - 2];
            return memo[n - 1] + memo[n - 2];

        }

        public static int Fibonacci(ulong n)
        {
            if (n == 0) return 0;
            int a = 0;
            int b = 1;
            for (uint i = 2; i < n; i++)
            {
                int c = a + b;
                a =  b;
                b = c ;
                
            }

            return a + b;
        }
        
    }
}