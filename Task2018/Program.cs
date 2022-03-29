using System;

namespace Task2018
{/*Задана последовательность n чисел a1, a2,..., an. Для нее вычисляется "хитрая" сумма: s=+a1-a2-a3+a4+a5+a6-a7-a8-a9-a10+..., т.е. знаки плюс и минус чередуются блоками, длина i-го блока равна i.
Выведите "хитрую" сумму заданной последовательности.
Входные данные
В первой строке задано целое число n (1 ≤ n ≤ 10000). Далее во второй строке задана последовательность a1, a2,..., an (1 ≤ ai ≤ 10000).
Выходные данные
Выведите "хитрую" сумму заданной последовательности.*/
    class Program
    {
        static void Main(string[] args)
        {
            int arrLength;
            int count = 1; //Счёт количества положительных/отрицательных членов подряд
            string[] input;
            int[] nums;
            bool negativeConversion = false; //определяет, когда члены массива нужно перемножить на -1
            int sum = 0;

            arrLength = Convert.ToInt32(Console.ReadLine());
            //input = new string[arrLength];
            nums = new int[arrLength + 1]; //для удобства работы массив начнётся с 1 члена, а не нулевого
            nums[0] = 0;  
            input = Console.ReadLine().Split();
            for(int i = 0; i < arrLength; i++)
            {
                nums[i + 1] = Convert.ToInt32(input[i]);                
            }

            for(int i = 1; i <= arrLength;)
            {
                //Console.WriteLine($"i = {i}, count = {count}");

                if(!negativeConversion)
                {                    
                    negativeConversion = true;
                    //Console.WriteLine($"+ {count} раз nCov = {negativeConversion}");
                }
                else if(negativeConversion)
                {                    
                    if( i + count < arrLength + 1)
                    {                        
                        for (int j = i; j < i + count; j++)
                        {
                            nums[j] *= (-1);
                            //Console.WriteLine($"nums j = {nums[j]}");
                        }
                        negativeConversion = false;
                    }
                    else
                    {
                        for (int j = i; j < arrLength + 1; j++)
                        {
                            nums[j] *= -1;
                        }
                        negativeConversion = false;
                    }
                    //Console.WriteLine($"- {count} раз");
                }                
                i += count;
                count++;
            }
            for (int i = 1; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
