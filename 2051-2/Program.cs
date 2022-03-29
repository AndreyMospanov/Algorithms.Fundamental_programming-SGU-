using System;
using System.Collections.Generic;

namespace Task20512
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int index = 0;
            List<int> Scobes = new List<int>();
            
            input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    Scobes.Add(i + 1);
                    index++;
                }
                else if (input[i] == ')' && input[i - 1] == '(')
                {
                    Scobes.Add(i + 1);
                    index++;
                }
                else
                {
                    Scobes.Insert(index - 1, i + 1);
                    index--;
                }
            }

            for (int node = 0; node < Scobes.Count; node++)
            {
                if(node % 2 == 1)
                Console.WriteLine("{0} {1}\n", Scobes[node-1], Scobes[node]);
            }
            Console.ReadLine();
        }
    }
}
