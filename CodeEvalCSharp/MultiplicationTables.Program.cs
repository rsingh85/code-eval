using System;
using System.IO;

namespace CodeEval.MultiplicationTables
{
    /// <summary>
    /// https://www.codeeval.com/open_challenges/23/
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    Console.Write("{0,-3} ", i * j);
                }

                Console.WriteLine();
            }
        }
    }
}