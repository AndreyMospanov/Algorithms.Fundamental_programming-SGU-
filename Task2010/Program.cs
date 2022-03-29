using System;

namespace Task2010
{
/*Наибольшим общим делителем (НОД) для двух целых чисел m и n называется наибольший из их общих делителей. Например, для чисел 70 и 105 наибольший общий делитель равен 35.
С давних времен известен следующий алгоритм нахождения наибольшего общего делителя двух неотрицательных целых чисел: пока оба числа строго положительны надо из большего числа вычесть меньшее. 
Результатом работы (наибольшим общим делителем) является большее число после окончания описанной серии вычитаний или 0, если оба числа в конце равны 0.
Вам заданы целые неотрицательные a и b (0 ≤ a,b ≤ 107). Напишите программу, которая выведет количество вычитаний при работе такого алгоритма и результат его работы.
Входные данные
Единственная строка входных данных содержит записанные через пробел целые числа a, b (0 ≤ a,b ≤ 10^7).
Выходные данные
Выведите количество вычитаний в ходе работы алгоритма и его результат через пробел.
*/
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, countSubtract, maxDivisor, subtraction, temp;
            string[] inputSplit;

            inputSplit = Console.ReadLine().Split();
            num1 = Convert.ToInt32(inputSplit[0]);
            num2 = Convert.ToInt32(inputSplit[1]);  
            
            if(num2 < num1)
            {
                temp = num1;
                num1 = num2;
                num2 = temp;
            }
            
            maxDivisor = num2;
            subtraction = num2 - num1;
            countSubtract = 0;

            while(num1 > 0 && num2 > 0)
            {
                num2 -= num1;
                if (num2 < num1)
                {
                    temp = num1;
                    num1 = num2;
                    num2 = temp;
                }
                countSubtract++;
                if (num1 > 0)
                    maxDivisor = num1;
            }            
            Console.WriteLine("{0} {1}", countSubtract, maxDivisor);            
        }
    }
}
