using System;
using System.IO;

namespace CodeEval.FizzBuzz
{
    /// <summary>
    /// https://www.codeeval.com/open_challenges/1/
    /// </summary>
    class Program
    {
        static void DisabledMain(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    if (null == line)
                        continue;

                    string[] arguments = line.Split(' ');
                    int x = int.Parse(arguments[0]);
                    int y = int.Parse(arguments[1]);
                    int max = int.Parse(arguments[2]);

                    for (int n = 1; n <= max; n++)
                    {
                        if (n % x == 0 && n % y == 0)
                            Console.Write("FB ");
                        else if (n % x == 0)
                            Console.Write("F ");
                        else if (n % y == 0)
                            Console.Write("B ");
                        else
                            Console.Write("{0} ", n);
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}