using System;
using System.Collections;

/*Дано n числовых последовательностей, последовательность номер i состоит из ki целых чисел.

Ваша задача — для каждого числа найти, в каких последовательностях оно встречается.

Входные данные
Первая строка содержит единственное число n — количество последовательностей (1 ≤ n ≤ 10^5). 
Далее в n строках находятся сами последовательности. Первое число в строке — это ki, 
далее находится список из ki чисел, входящих в последовательность i. Числа разделены пробелом. 
Все числа из входных данных не менее 0 и не более 10^9. Сумма ki не превосходит 10^9.

Выходные данные
Выходные данные должны содержать столько строк, сколько различных чисел встречается во всех последовательностях. 
Каждая строка начинается с целого числа, а далее через пробел перечислены номера последовательностей, 
где встречается это число. Номера выводите в возрастающем порядке, причем в одной строке каждый номер 
должен выводиться не более одного раза. Первые числа в строках должны образовывать возрастающую последовательность.*/

namespace Task2054
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayCount;
            Hashtable ht = new Hashtable();
            
            string [] tempStr;
            arrayCount = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < arrayCount; i++)
            {
                tempStr = Console.ReadLine().Split(' ');
                string temp = (i + 1).ToString() + " ";
                for (int j = 1; j < tempStr.Length; j++)
                {
                    if (ht.ContainsKey(tempStr[j]))
                    {
                        if(!ht[tempStr[j]].ToString().Contains(temp))
                        {
                            ht[tempStr[j]] += temp;
                        }                        
                    }
                    else
                    {
                        ht.Add(tempStr[j], temp);
                    }
                }
            }
            
            foreach(DictionaryEntry de in ht)
            {
                Console.WriteLine("{0} {1}", de.Key, de.Value);
            }
            Console.ReadKey();
        }
    }
}
