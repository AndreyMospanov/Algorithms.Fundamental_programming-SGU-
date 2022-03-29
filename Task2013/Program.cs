using System;

namespace Task2013
{
    /*Задана последовательность n целых чисел a1, a2,..., an. Выведите количество ее элементов, равных минимальному.
    Входные данные
    В первой строке записано целое число n (1 ≤ n ≤ 10000). Вторая строка содержит последовательность n целых чисел a1, a2,..., an (-10000 ≤ ai ≤ 10000).
    Выходные данные
    Выведите искомое количество минимумов.*/
    class Program
    {
        static void Main(string[] args)
        {
            int arrLength;
            string[] input;
            int[] array;
            int minimum;
            int count = 0;

            arrLength = Convert.ToInt32(Console.ReadLine());
            input = Console.ReadLine().Split();
            array = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                array[i] = Convert.ToInt32(input[i]);
            }
            minimum = array[0];
            for (int i = 0; i < arrLength; i++)
            {
                minimum = minimum < array[i] ? minimum : array[i];
            }
            for (int i = 0; i < arrLength; i++)
            {
                if(array[i] == minimum)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
