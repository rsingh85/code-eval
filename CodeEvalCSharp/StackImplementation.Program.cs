using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CodeEval.StackImplementation
{
    /// <summary>
    /// https://www.codeeval.com/open_challenges/9/
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            using (StreamReader reader = File.OpenText(args[0]))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    if (null == line)
                        continue;

                    line.Split(' ')
                        .ToList()
                        .ForEach(n => stack.Push(n));
                    
                    while (stack.Any())
                    {
                        Console.Write("{0} ", stack.Pop());

                        if (stack.Any())
                            stack.Pop();
                    }

                    Console.WriteLine();
                    stack.Clear();
                }
            }           
        }
    }
}