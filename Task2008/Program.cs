using System;

namespace Task2008
{
/*Задана грузоподъемность грузовика w (в тоннах). На него последовательно грузятся предметы массами a1, a2,..., an, где ai — масса i-го груза в тоннах. 
Если при погрузке очередного предмета рабочие замечают, что в случае завершения процесса суммарный вес погруженных предметов превысит грузоподъемность, 
то погрузка этого предмета не осуществляется (он пропускается).
Выведите количество предметов, которые будут погружены в соответствии с алгоритмом выше и их суммарную массу.
Входные данные
В первой строке записана пара целых чисел n, w (1 ≤ n ≤ 10000, 1 ≤ w ≤ 10000). Вторая строка содержит последовательность целых чисел a1, a2,..., an (1 ≤ ai ≤ 10000).
Выходные данные
Выведите количество погруженных предметов и их суммарную массу.*/
    class Program
    {
        static void Main(string[] args)
        {
            string[] input1Split;
            int loadAmount; 
            int weightCapacity;
            string[] input2Split;
            int[] loadWeights;
            int totalWeight = 0;
            int count = 0;

            input1Split = Console.ReadLine().Split();
            loadAmount = Convert.ToInt32(input1Split[0]);
            weightCapacity = Convert.ToInt32(input1Split[1]);
            input2Split = Console.ReadLine().Split();
            loadWeights = new int[loadAmount];

            for (int i = 0; i < loadAmount; i++)
            {
                loadWeights[i] = Convert.ToInt32(input2Split[i]);
                if(totalWeight + loadWeights[i] <= weightCapacity)
                {
                    totalWeight += loadWeights[i];
                    count++;
                }
            }
            Console.WriteLine("{0} {1}", count, totalWeight);            
        }
    }
}
