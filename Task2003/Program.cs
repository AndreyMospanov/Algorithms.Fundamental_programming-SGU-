using System;

namespace Task2003
{
/*Альтернированной суммой заданной последовательности n чисел a1, a2,..., an называется число s=a1-a2+a3-a4+.... 
* В альтернированной сумме знаки слагаемых чередуются, альтернация начинается со знака "+".
По заданной последовательности целых чисел выведите ее альтернированную сумму.
Входные данные
В первой строке задано целое число n (1 ≤ n ≤ 10000). Вторая строка содержит n целых чисел, каждое от 1 до 10000 включительно.
Выходные данные
Выведите искомую альтернированную сумму.*/
    class Program
    {
        static void Main(string[] args)
        {
            int arrLength = Convert.ToInt32(Console.ReadLine());
            string input = Console.ReadLine();
            string[] splitInput = input.Split(' ');
            int[] summands = new int[arrLength];
            int altSum = 0;
            for (int i = 0; i < arrLength; i++)
            {
                summands[i] = Convert.ToInt32(splitInput[i]);                
            }

            for ( int i = 0; i < arrLength; i++)
            {
                if(i % 2 == 1)
                {
                    summands[i] *= -1;
                }
                altSum += summands[i];
            }
            Console.WriteLine(altSum);
        }
    }
}
