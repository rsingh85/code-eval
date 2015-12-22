using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace CodeEval.NumberOfOnes
{
    /// <summary>
    /// https://www.codeeval.com/open_challenges/16/
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
                        Convert.ToString(
                            int.Parse(line), 2
                        ).Count(c => c == '1')
                    );
                }
            }

            Console.ReadLine();
        }
    }
}