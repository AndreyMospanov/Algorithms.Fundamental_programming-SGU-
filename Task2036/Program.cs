using System;
using System.Text;

/*Дан набор из n слов, состоящих из маленьких латинских букв.
Будем называть слово странным, если в нем встречаются 3 или более гласные буквы подряд.
Ваша задача — удалить из данного набора все странные слова.
Гласными буквами в латинском алфавите считаются e,y,u,i,o,a.*/

namespace Task2036
{   
    class Program
    {
        private static string[] ReadStrings(int dataCount)
        {
            string[] input = new string[dataCount];            
            for (int i = 0; i < dataCount; i++)
            {
                input[i] = Console.ReadLine();
            }
            return input;
        }

        private static void DeleteStrangeWords(string[] data)
        {            
            char[] temp;
            char[] vowels = { 'e', 'y', 'u', 'i', 'o', 'a' };
            int countVowels = 0;
            for (int i = 0; i < data.Length; i++)//перебираем все строки
            {               
                temp = new char[data[i].Length];
                temp = data[i].ToCharArray();
                countVowels = 0;
                for(int j = 0; j < temp.Length; j++)//перебираем массив символов
                {
                    for (int k = 0; k < vowels.Length; k++ )//перебираем массив с гласными
                    {
                        if(temp[j] == vowels[k])
                        {
                            countVowels++;
                            //Console.WriteLine($"Debug char {temp[j]} vowel {vowels[k]} count = {countVowels}");
                            break;                            
                        }
                        if(k == vowels.Length - 1 && temp[j] != vowels[k])
                        {                            
                            countVowels *= 0;
                            //Console.WriteLine($"else count = {countVowels}");
                        }                        
                    }
                    if(countVowels >= 3)
                    {
                        //Console.WriteLine("countVowels = 3");
                        break;                        
                    }
                    if (j == temp.Length - 1)
                    {
                        StringBuilder sb = new StringBuilder();
                        foreach (char c in temp)
                        {
                            sb.Append(c);
                        }
                        Console.WriteLine(sb.ToString());
                    }
                }                
            }
        }
        static void Main(string[] args)
        {
            int dataCount;            
            string[] data;

            dataCount = Convert.ToInt32(Console.ReadLine());

            data = ReadStrings(dataCount);
            DeleteStrangeWords(data);
            //Console.ReadKey();
        }
    }
}
