using System;

namespace Task2040
{
/*Циклическим сдвигом на k строки p = (p1, p2,..., pn) называется строка pk = (pk+1, pk+2,..., pn, p1,..., pk).
Ваша задача — найти наименьший в лексикографическом порядке сдвиг данной строки.
Входные данные
Входные данные состоят из единственной строки p, состоящей только из маленьких латинских букв. 
Длина строки не превосходит 1000 символов.
Выходные данные
Выведите искомый наименьший циклический сдвиг данной строки p.*/
    class Program
    {
        private static string Shift (string s)
        {
            s += s;
            int n = s.Length;
            int i = 0, ans = 0;
            while (i < n / 2)
            {
                ans = i;
                int j = i + 1, k = i;
                while (j < n && s[k] <= s[j])
                {
                    if (s[k] < s[j])
                        k = i;
                    else
                        ++k;
                    ++j;
                }
                while (i <= k) i += j - k;
            }
            return s.Substring(ans, n / 2);
        }
            static void Main(string[] args)
        {
            string input;           
            input = Console.ReadLine();                    
            Console.WriteLine(Shift(input));          
        }
    }
}
