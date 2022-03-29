using System;

namespace Task2005
{/*Заданы n целых чисел. Выведите индекс (позицию) первого из минимальных элементов последовательности. Элементы последовательности занумерованы от 1 слева направо.
Входные данные
В первой строке записано целое число n (1 ≤ n ≤ 10000). Вторая строка содержит последовательность целых чисел a1, a2,..., an (-10000 ≤ ai ≤ 10000).
Выходные данные
Выведите искомый индекс.*/
    class Program
    {
        static void Main(string[] args)
        {
            int arrLength = Convert.ToInt32(Console.ReadLine());
            string input = Console.ReadLine();
            string[] splitInput = input.Split(' ');
            int[] numList = new int[arrLength];
            int minimum;            
            int minimumIndex = 1;

            for (int i = 0; i < arrLength; i++)
            {
                numList[i] = Convert.ToInt32(splitInput[i]); 
            }

            minimum = numList[0];

            for (int i = 0; i < arrLength; i++)
            {
                if (numList[i] < minimum)
                {                   
                    minimum = numList[i];
                    minimumIndex = (i + 1);                   
                }                
            }            
            Console.WriteLine(minimumIndex);
        }
    }
}
