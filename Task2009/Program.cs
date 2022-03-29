using System;

namespace Task2009
{
/*Задана последовательность n целых чисел a1, a2,..., an. Выведите сумму всех ее элементов, стоящих на позициях, которые являются степенями двойки: 1, 2, 4, 8, 16 и т.д.
Входные данные
В первой строке задано целое число n (1 ≤ n ≤ 10000). Вторая строка содержит последовательность целых чисел a1, a2,..., an.
Выходные данные
Выведите искомую сумму.*/
    class Program
    {
        static void Main(string[] args)
        {
            int arrLength;
            string[] inputSplit;
            int[] nums;
            int power = 0;
            int count = 1;
            int sum = 0;

            arrLength = Convert.ToInt32(Console.ReadLine());            
            inputSplit = Console.ReadLine().Split();
            nums = new int[arrLength + 1];
            nums[0] = 0;

            for(int i = 0; i < arrLength; i++)
            {
                nums[i + 1] = Convert.ToInt32(inputSplit[i]);
            }

            for(int i = 0; i <= arrLength; i++)
            {
                if(i == count)
                {
                    sum += nums[i];
                    //Console.WriteLine($"i = {i}; power = {power} count = {count} sum = {sum} ");
                    power++;
                    count = Convert.ToInt32(Math.Pow(2.0, power));                    
                }
            }
            Console.WriteLine(sum);            
        }
    }
}
