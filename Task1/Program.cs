using System;

namespace Task2001
{
    /*Заданы a и b. Выведите a+b.
Входные данные
В единственной строке входных данных заданы целочисленные a и b (1 ≤ a,b ≤ 1000).
Выходные данные
Выведите a+b.*/
    class Program
    {
        static void Main(string[] args)
        {
            int[] summands = { 0, 0};
            string input;
            string[] str;
            input = Console.ReadLine();            
            str = input.Split(' ');
           for(int i = 0; i < str.Length; i++)
            {
                summands[i] = Convert.ToInt32(str[i]);                
            }
            Console.WriteLine(summands[0] + summands[1]);
        }
    }
}
