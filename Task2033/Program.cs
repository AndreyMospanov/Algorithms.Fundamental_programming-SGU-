using System;

namespace Task2033
{
/*Задано длинное целое положительное число массивом своих цифр. Требуется прибавить к этому числу единицу.
Входные данные
В первой строке записано целое число n (1 ≤ n ≤ 1000), n — количество цифр в заданном числе. 
Вторая строка содержит описание числа в виде последовательности цифр, которые заданы через пробел. 
Цифры заданы слева направо (от старшей к младшей). Заданное число — положительное, первая (старшая) цифра отлична от 0.
Выходные данные
Выведите число после прибавления к нему единицы в формате, аналогичном формату входных данных. 
Первая строка должна содержать количество цифр в числе, а вторая — сами цифры через пробел. 
Первая (старшая) цифра должны быть отлична от 0.*/
    class Program
    {
        private static int[] ReadArray(int arrLength)
        {
            string[] input = Console.ReadLine().Split();
            int[] array = new int[arrLength];
            for (int i = 0; i < arrLength; i++)
            {
                array[i] = Convert.ToInt32(input[i]);
            }
            return array;
        }
        private static void PrintAnswer(int[] arr)
        {
            Console.WriteLine(arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
        private static void Calculate(int[] arr, int arrLength)
        {
            int allNumsAreNine = 0;
            int[] answerArray;
            int plusNum = 0;
            
            //Вычисляем частный случай, если прибавка единицы изменит порядок числа
            for (int i = 0; i < arrLength; i++)
            {
                if (arr[i] == 9)
                {
                    allNumsAreNine++;
                }
            }
            if (allNumsAreNine == arrLength)
            {
                answerArray = new int[arrLength + 1];
                answerArray[0] = 1;
                for (int i = 1; i < answerArray.Length; i++)
                {
                    answerArray[i] = 0;
                }
                PrintAnswer(answerArray);
            }
            //вычисляем остальные случаи
            else
            {
                answerArray = new int[arrLength];
                //вычисляем частный случай, если число оканчивается на 9
                if (arr[arrLength - 1] == 9)
                {
                    answerArray[arrLength - 1] = 0;
                    plusNum++;
                    for(int i = arrLength - 2; i >= 0; i--)
                    {
                        if(plusNum == 1)
                        {
                            if (arr[i] != 9)
                            {
                                answerArray[i] += arr[i] + 1;
                                plusNum--;
                            }
                            else
                            {
                                answerArray[i] = 0;
                            }
                        }
                        else
                        {
                            answerArray[i] = arr[i];
                        }                        
                    }
                    PrintAnswer(answerArray);
                }
                //если число не оканчивается на 9
                else
                {                    
                    answerArray[arrLength - 1] = arr[arrLength - 1] + 1;
                    for (int i = 0; i < arrLength - 1; i++)
                    {
                        answerArray[i] = arr[i];
                    }
                    PrintAnswer(answerArray);
                }
            }
        }
        static void Main(string[] args)
        {
            int arrLength;
            int[] arr;

            arrLength = Convert.ToInt32(Console.ReadLine());
            arr = ReadArray(arrLength);
            Calculate(arr, arrLength);
            //Console.ReadLine();
        }
    } 
}
