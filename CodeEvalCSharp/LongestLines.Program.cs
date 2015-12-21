using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace CodeEval.LongestLines
{
    /// <summary>
    /// https://www.codeeval.com/open_challenges/2/
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lines = null;
            int max = 0;

            using (StreamReader reader = File.OpenText(args[0]))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    if (null == line)
                        continue;

                    if (lines == null)
                    {
                        lines = new List<string>();
                        max = int.Parse(line);

                        continue;
                    }

                    lines.Add(line);
                }
            }

            foreach (string line in lines.OrderByDescending(l => l.Length).Take(max))
            {
                Console.WriteLine(line);
            }
        }
    }
}