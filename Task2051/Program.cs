using System;
using System.Collections.Generic;

namespace Task2051
{
    /*Пра?вильная ско?бочная после?довательность (ПСП) формально определяются следующим образом:
    пустая последовательность - ПСП
    если s — ПСП, то (s) — тоже ПСП
    если s1 и s2 — ПСП, то s1 s2 — тоже ПСП
    Например, (())() — ПСП, а (()))(()) — нет.
    Дана ПСП, ваша задача для каждой открывающей скобочки найти позицию ей соответствующей закрывающей скобочки.
    Входные данные
    Входные данные состоят из единственной строки (гарантируется, что эта строка — ПСП), длиной не более 10^5.
    Выходные данные
    Выведите n строк, где n — количество пар скобок во входной строке. Каждая строка должна содержать пару чисел — сначала позицию открывающей скобочки, 
    потом позицию закрывающей. Пары следует выводить в порядке возрастания позиций открывающих скобочек. Числа разделяйте пробелом. Нумерация позиций в строке начинается с 1.*/
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            
            List<int> openScobes = new List<int>(50000);
            List<int> closedScobes = new List<int>(50000);
            Stack<int> pos = new Stack<int>();
            input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    openScobes.Add(i + 1);
                    pos.Push(openScobes.Count - 1);
                }
                else if (input[i] == ')' && input[i - 1] == '(')
                {
                    closedScobes.Add(i + 1);
                    pos.Pop();
                }
                else
                {
                    Console.WriteLine(") " + pos.Peek() + $"index = {i+1}");
                    closedScobes.Insert(pos.Peek(), i + 1);
                    pos.Pop();
                }
                if(pos.Count > 0)
                    Console.WriteLine(pos.Peek());
            }

            for (int node = 0; node < closedScobes.Count; node++)
            {
                Console.WriteLine("{0} {1}", openScobes[node], closedScobes[node]);
            }
            Console.ReadLine();
        }
    }
}
