using System;

namespace Task2035
{
/*Периодом массива a=(a1, a2,..., an) называется такой его кратчайший подмассив b=(a1, a2,..., ak), что k делит n, 
 * а будучи записанным n/k раз подряд он в точности окажется равным a.
Например, у массива (1, 2, 1, 1, 2, 1, 1, 2, 1) длина периода равна 3,
а сам период — (1, 2, 1), у массива (1, 1, 1) длина периода равна 1, а у массива (1, 2, 3, 4) — длина периода равна 4.
Ваша задача по заданному массиву найти длину его периода.
Входные данные
В первой строке записано целое положительное число n (1 ≤ n ≤ 10000), где n — длина заданного массива. 
Вторая строка содержит последовательность целых чисел a1, a2,..., an (1 ≤ ai ≤ 10000) — последовательность элементов заданного массива.
Выходные данные
Выведите искомую длину периода.*/
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
            int period = 1;
            int num;
            if (period == arrLength)
            {
                num = 0;
            }                
            else
            {
                num = period;
            }  
            for (int i = 0; i < period; i++)
            {
                //Console.WriteLine($"arr[{i}] = {arr[i]}; arr[{num}] = {arr[num]}");
                //блок, в котором очередной цикл сошёлся
                if (i == period - 1 && arr[num] == arr[i])
                {
                    //если цикл уже прошёл одну итерацию, сравниваем его с последующими членами
                    
                    if(num == arrLength - 1)
                    {
                        Console.WriteLine(period);
                        break;
                    }
                    else if(num != arrLength - 1)
                    {
                        num++;
                        i = -1;
                    }
                }
                //проверяем очередной член массива на сходство с периодом
                else if (arr[num] == arr[i])
                {
                    //Console.WriteLine($"Прибавляем нум = {num}");
                    num++;
                }
                //если члены подмассивов не сходятся, переходим к следующему периоду
                else
                {                    
                    //чтобы исключить лишние расчёты, проверим,  будет ли следующий период делиться на длину массива без остатка
                    for (int a = 1; a < arrLength; a++)
                        if (arrLength % (period + a) == 0)
                        {
                            period += a;
                            num = period;                            
                            break;
                        }
                    if (period == arrLength)
                    {
                        Console.WriteLine(period);
                        break;
                    }
                    i = -1;
                    //Console.WriteLine($"Invalid. Next period = {period}");
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
            //Console.ReadKey();
        }
    }
}
