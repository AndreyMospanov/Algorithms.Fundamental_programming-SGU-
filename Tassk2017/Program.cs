using System;

namespace Task2017
{
/*Вам задана пара целых чисел a, b (1 ≤ a ≤ b ≤ 5000). Выведите все числа из отрезка [a,b], которые имеют наибольшее количество делителей из всех чисел в этом отрезке.
Входные данные
В единственной строке входных данных заданы числа a, b (1 ≤ a ≤ b ≤ 5000).
Выходные данные
В первую строку выведите количество найденных чисел. Во вторую строку выведите сами числа, числа разделяйте запятыми 
(без каких-либо пробелов). Запятую после последнего числа выводить не надо (см. примеры).*/
    class Program
    {
        static void Main(string[] args)
        {
            string[] input;            
            int min, max;
            int[] divisionCount;
            int maxCount = 0; //Максимальное количество делителей
            int numCount = 0; //Количество цифр с максимальным количеством делителей
            bool firstNum = true; //Для вывода. Если цифра является первой

            input = Console.ReadLine().Split();
            min = Convert.ToInt32(input[0]);
            max = Convert.ToInt32(input[1]);            
            divisionCount = new int[max+1];

            for(int i = min; i <= max; i++)
            {
                divisionCount[i] = 0;
               for(int j = 1; j <= i; j++)
                {
                    if(i % j == 0)
                    {
                        divisionCount[i]++;
                    }
                }
                //Console.WriteLine($"Debug num = {i}, divisions = {divisionCount[i]}");
            }

            //Узнаём максимальный делитель
            for (int i = min; i <= max; i++)
            {
                maxCount = maxCount > divisionCount[i] ? maxCount : divisionCount[i];
            }

            //Узнаём количество цифр с максимальным количеством делителей
            for (int i = min; i <= max; i++)
            {
                if (divisionCount[i] == maxCount)
                {
                    numCount++;
                }
            }
            Console.WriteLine(numCount);

            //Выводим на экран цифры
            for (int i = min; i <= max; i++)
            {
                if(!firstNum)
                {
                    if (divisionCount[i] == maxCount)
                    {
                        Console.Write(",{0}", i);
                    }
                }
                else if(firstNum)
                {
                    if (divisionCount[i] == maxCount)
                    {
                        Console.Write("{0}", i);
                        firstNum = false;
                    }
                }   
            }
            //Console.ReadKey();
        }
    }
}
