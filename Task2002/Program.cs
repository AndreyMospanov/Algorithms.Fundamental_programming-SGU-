using System;

namespace Task2002
{
/*Задано n целых чисел. Выведите их сумму.
Входные данные
В первой строке задано целое число n (1 ≤ n ≤ 10000). Вторая строка содержит n целых чисел, каждое от 1 до 10000, включительно.
Выходные данные
Выведите искомую сумму.*/
    class Program
    {
        static void Main(string[] args)
        {
            int arrLength = Convert.ToInt32(Console.ReadLine());            
            string input = Console.ReadLine();
            string[] splitInput = input.Split(' ');
            int[] summands = new int[arrLength];
            int sum = 0;
            for(int i = 0; i < arrLength; i++)
            {
                summands[i] = Convert.ToInt32(splitInput[i]);
                sum += summands[i];
            }
            Console.WriteLine(sum);
        }
    }
}
