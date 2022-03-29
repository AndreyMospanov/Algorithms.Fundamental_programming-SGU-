using System;

namespace Task2012
{
/*Верно ли, что два заданных прямоугольника a1 x b1 и a2 x b2 были получены разрезанием некоторого квадрата одним прямолинейным разрезом? Напишите программу, которая выведет YES или NO.
Входные данные
В первой строке заданы числа целые a1, b1 (1 ≤ a1,b1 ≤ 1000), во второй — числа целые a2, b2 (1 ≤ a2,b2 ≤ 1000). Числа в строках заданы через пробел.
Выходные данные
Выведите YES или NO.*/
    class Program
    {
        static void Main(string[] args)
        {
            string[] input1;
            string[] input2;
            string answer;
            int[] rect1 = new int[2];
            int[] rect2 = new int[2];
            int max1, min1, max2, min2;

            input1 = Console.ReadLine().Split();
            input2 = Console.ReadLine().Split();
            rect1[0] = Convert.ToInt32(input1[0]);
            rect1[1] = Convert.ToInt32(input1[1]);
            rect2[0] = Convert.ToInt32(input2[0]);
            rect2[1] = Convert.ToInt32(input2[1]);
            max1 = rect1[0] > rect1[1] ? rect1[0] : rect1[1];
            min1 = rect1[0] < rect1[1] ? rect1[0] : rect1[1];
            max2 = rect2[0] > rect2[1] ? rect2[0] : rect2[1];
            min2 = rect2[0] < rect2[1] ? rect2[0] : rect2[1];

            if(min1 + min2 == max1 && max1 == max2)
            {
                answer = "YES";
            }
            else
            {
                answer = "NO";
            }
            Console.WriteLine(answer);
        }
    }
}
