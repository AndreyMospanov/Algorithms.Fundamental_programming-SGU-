using System;

namespace Task2034
{
    /*Задан массив (a1, a2,..., an). Его подмассив — это последовательность одного или более его подряд идущих элементов. 
    Очевидно, что подмассив можно задать парой целых чисел l,r (1 ≤ l ≤ r ≤ n), обозначающих подмассив с позиции l по r включительно.
    Подмассив будем называть почти константным, если любые два элементы в нем отличаются не более чем на единицу. Например, в массиве 
    (3, 2, 1, 2, 3, 4) подмассив с позиции 2 по позицию 4 — почти константный, также таким является помассив с позиции 4 по позицию 5, 
    но подмассив с позиции 3 по позицию 5 таковым не является.
    Ваша задача найти самый длинный почти константный подмассив. Если таких несколько, то выведите такой, который начинается с минимальной позиции.
    Входные данные
    В первой строке записано целое положительное число n (1 ≤ n ≤ 10000), где n — длина заданного массива. 
    Вторая строка содержит последовательность a1, a2,..., an (1 ≤ ai ≤ 10000) — последовательность элементов заданного массива.
    Выходные данные
    Выведите l, r для искомого подмассива. Числа выводите через пробел.*/
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

        private static void Calculate(int[] arr, int arrLength)
        {
            int maxL = 0;
            int maxR = 0;
            int maxLength = 0;

            //проеряем условие если члены подмассива равны или больше на 1
            for(int l = 0; l < arrLength; l++)
            {
                for(int r = l; r < arrLength; r++)
                {                    
                    if(arr[l] == arr[r] || arr[r] == arr[l] + 1)
                    {
                        if (r - l > maxLength)
                        {
                            maxL = l;
                            maxR = r;
                            maxLength = r - l;
                            //Console.WriteLine($"1. r {r} - l {l} = maxLength{maxLength}");
                        }                        
                    }
                    else
                    {
                        break;
                    }   
                }                
            }
            //проеряем условие если последующие члены подмассива меньше на 1
            for (int l = 0; l < arrLength; l++)
            {
                for (int r = l; r < arrLength; r++)
                {
                    if (arr[l] == arr[r] || arr[r] == arr[l] - 1)
                    {                        
                        if (r - l > maxLength)
                        {
                            maxL = l;
                            maxR = r;
                            maxLength = r - l;
                            //Console.WriteLine($"2. r {r} - l {l} = maxLength{maxLength}");
                        }                        
                    }
                    else
                    {
                        break;
                    }                    
                }               
            }
            Console.WriteLine("{0} {1}", maxL + 1, maxR + 1);
        }

        static void Main(string[] args)
        {
            int arrLength;
            int[] arr;

            arrLength = Convert.ToInt32(Console.ReadLine());
            arr = ReadArray(arrLength);
            Calculate(arr, arrLength);
            //Console.ReadKey();
        }
    }
}
