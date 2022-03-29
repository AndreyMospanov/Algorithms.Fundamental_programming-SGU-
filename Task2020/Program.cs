using System;

namespace Task2020
{
/*Задана последовательность a1, a2,..., an, которая отсортирована по неубыванию. 
Выведите наиболее часто встречающееся в ней значение и количество его появлений в последовательности.
Входные данные
В первой строке задано целое число n (1 ≤ n ≤ 10000). Вторая строка содержит n целых чисел, 
каждое от 1 до 10000 включительно. Заданная последовательность отсортирована по неубыванию.
Выходные данные
Выведите два целых числа f, c (числа разделяйте пробелом), где f — значение наиболее часто 
встречающегося элемента последовательности и c — количество его появлений. Если существует 
несколько возможных значений для f, то выведите наименьшее из них.*/
    class Program
    {
        static void Main(string[] args)
        {
            int arrLength, maxIndex, number;
            string[] input;
            int[] arr;
            int[] numCount;

            arrLength = Convert.ToInt32(Console.ReadLine());            
            input = Console.ReadLine().Split();
            arr = new int[arrLength];
            numCount = new int[arrLength];

            //первоначальное допущение, что кажджый номер в массиве arr встречается по одному разу
            for (int i = 0; i < arrLength; i++)
            {
                numCount[i] = 1;
            }

            for (int i = 0; i < arrLength; i++)
            {
                arr[i] = Convert.ToInt32(input[i]);
            }

            //добавляем numCount каждый раз, когда i-тый член делится на  предыдущий
            for (int i = 1; i < arrLength; i++)
            {
                if(arr[i] % arr[i - 1] == 0 && arr[i] / arr[i - 1] == 1)
                {
                    numCount[i] = numCount[i - 1] + 1;
                }
            }
            maxIndex = numCount[0];
            number = arr[0];
            //выявляем максимум в массиве счётчиков
            for (int i = 1; i < arrLength; i++)
            {
                if (numCount[i] > maxIndex)
                {
                    maxIndex = numCount[i]; // максимальном количетву соответствует нужная цифра в arr
                    number = arr[i];
                }
            }
            Console.WriteLine("{0} {1}", number, maxIndex);
            //Console.ReadLine();
        }
    }
}
