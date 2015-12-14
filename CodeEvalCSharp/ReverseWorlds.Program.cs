using System;
using System.IO;
using System.Linq;

/// <summary>
/// https://www.codeeval.com/open_challenges/8/
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
                    string.Join(" ", line.Split(' ').Reverse())
                );
            }
        }
    }
}
