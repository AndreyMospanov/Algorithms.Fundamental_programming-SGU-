using System;

namespace Task20412
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
        static bool Palindrome(string input, int left, int right)
        {
            bool isPalindrome = false;
            while (left < right)
            {
                if (input[left] == input[right])
                {
                    left++;
                    right--;
                    isPalindrome = true;
                }
                else
                {
                    isPalindrome = false;
                    return isPalindrome;                    
                }                
            }
            return isPalindrome;
        }
        static void Main(string[] args)
        {
            bool[] isPalindrome = { false, false };
            int wordNum = 0;
            int index = 0;            
            int[] palindromeLength = {0, 0};
            string input;
            input = Console.ReadLine();

         
            for (int i = 0; i < input.Length;)//перебираем каждую букву в слове
            {
                for (int j = input.Length - 1; j > i; j--)//сравниваем буквы между собой
                {
                    if (input[i] == input[j])
                    {
                        isPalindrome[wordNum] = Palindrome(input, i, j);                        
                    }
                    if (isPalindrome[wordNum])
                    {
                        palindromeLength[wordNum] = j - i + 1;
                        index = j + 1;
                        break;
                    }                    
                }                
                if (isPalindrome[wordNum])
                {                    
                    i = index;
                    wordNum++;
                    if (wordNum > 1 && i < input.Length)
                    {
                        isPalindrome[1] = false;
                        break;
                    }
                }   
                else
                {
                    i++;
                }                
            }
            if (isPalindrome[0] == false || isPalindrome[1] == false)
            {
                wordNum = 0;
                isPalindrome[0] = false;
                isPalindrome[1] = false;

                for (int i = input.Length - 1; i > 0;)//перебираем каждую букву в слове
                {
                    for (int j = 0; j < i; j++)//сравниваем буквы между собой
                    {
                        if (input[i] == input[j])
                        {
                            isPalindrome[wordNum] = Palindrome(input, j, i);
                        }
                        if (isPalindrome[wordNum])
                        {
                            palindromeLength[wordNum] = i - j + 1;
                            index = j - 1;
                            break;
                        }                        
                    }
                    if (isPalindrome[wordNum])
                    {                        
                        i = index;
                        wordNum++;
                        if (wordNum > 1 && index > 0 || isPalindrome[1] == true)
                        {
                            isPalindrome[1] = false;
                            break;
                        }
                    }
                    else
                    {
                        i--;
                    }
                }
            }

            if (isPalindrome[0])//частные случаи с однобуквенными и пустыми вторыми палиндромами
            {
                if (isPalindrome[1] && input.Length != palindromeLength[0] + palindromeLength[1])
                {
                    isPalindrome[1] = false;
                }
                if (input.Length - palindromeLength[0] < 2)
                {
                    isPalindrome[1] = true;
                }                
            }
            if (input.Length <= 2)
            {
                Console.WriteLine("YES");
            }
            else if (isPalindrome[0] == true && isPalindrome[1] == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            //Console.ReadLine();
        }
    }
}