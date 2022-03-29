using System;

namespace Task2041
{
/*Строка называется палиндромом, если она читается справа налево и слева направо одинаково. Например, "abacaba" — палиндром, а "abac" — нет.
Конкатенацией двух строк называется строка, представляющий собой сначала записанную первую строку, потом вторую. Например, "ad" + "caba" = "adcaba".
Дана строка, состоящая только из строчных латинских букв. Ваша задача проверить, является ли эта строка конкатенацией двух палиндромов. Обратите внимание, 
что пустая строка также является палиндромом.
Входные данные
Входные данные состоят из единственной строки, 
состоящей только из строчных латинских букв, длиной не более 1000 символов.
Выходные данные
Выведите "YES", если данная строка — конкатенация двух палиндромов, и "NO" 
в противном случае. Кавычки выводить не требуется.*/
    class Program
    {
        static void Main(string[] args)
        {
            bool[] isPalindrome = { false, false };
            int wordNum = 0;
            string input;
            input = Console.ReadLine();
            
            //логика
            for(int i = 0; i < input.Length; i++)//перебираем каждую букву в слове
            {
                for(int j = input.Length - 1; j > i; )//сравниваем буквы между собой
                {
                    if(input[i] == input[j])
                    {
                        int left = i;
                        int right = j;
                        while(left < right)
                        {
                            if(input[left] == input[right])
                            {
                                left++;
                                right--;
                                isPalindrome[wordNum] = true;                                
                            }
                            else
                            {
                                isPalindrome[wordNum] = false;
                                break;
                            }
                        }                        
                    }
                    if(isPalindrome[wordNum])
                    {
                        wordNum++;
                    }
                    if (isPalindrome[0])
                    {
                        //частные случаи с однобуквенными словами и одним палиндромом
                        if (i == 1 && j + 1 == input.Length)//если перед палиндромом было однобуквенное слово
                        {
                            isPalindrome[1] = true;
                        }
                        else if (i == 0 && input.Length - (j + 1) == 1)//если после палиндрома однобуквенное слово
                        {
                            isPalindrome[1] = true;
                        }
                        else if (i == 0 && input.Length == j + 1)//если слово состоит только из одного палиндрома
                        {
                            isPalindrome[1] = true;
                        }
                        i = j + 1;// переход к следующему слову
                       
                        break;
                    }
                    if (isPalindrome[1])
                    {                        
                        if(input.Length - j > 1)
                        {
                            isPalindrome[1] = false;
                            break;
                        }
                    }
                    j--;
                } 
                if(wordNum > 1)
                {
                    isPalindrome[1] = false;
                    break;
                }
            }
            //блок записи результатов
            if (input.Length <= 2)
            {
                Console.WriteLine("YES");
            }
            else if(isPalindrome[0] == true && isPalindrome[1] == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.ReadLine();
        }
    }
}
