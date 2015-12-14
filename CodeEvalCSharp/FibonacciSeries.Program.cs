using System;
using System.IO;

namespace CodeEval.FibonacciSeries
{
    /// <summary>
    /// https://www.codeeval.com/open_challenges/22/
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    if (null == line)
                        continue;

                    Console.WriteLine(
                        Fibonacci(int.Parse(line))
                    );
                }
            }
        }

        static int Fibonacci(int n)
        {
            if (n == 0 || n == 1) return n;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}