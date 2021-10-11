using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {//  А роза упала на лапу Азора
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение палиндром, знаки препинания не использовать");
            string s1 = Console.ReadLine(); //Ввод с клавиатуры
            #region Убираем пробелы и большие буквы
           
            string[] stringArray = s1.Split();
            string s2 = "";
            string s4 = "";
            foreach (string s3 in stringArray)
            {
                s4 += s3.Substring(0,1).ToLower() + s3.Substring(1);
                s2=s4.ToLower();
            }
           
            // убрав пробелы и заглавные буквы, получаем s2
            #endregion
            #region Решение
            bool Palindrom = true;
            for (int i = 0; i < (s2.Length/2); i++)
            {
                if (s2[i] != s2[s2.Length - i - 1])
                {
                    Palindrom = false;
                    break;
                }
                else Palindrom = true;
            }
            #endregion
            #region Ответ
            if (Palindrom == true)
            {
                Console.WriteLine(" Предложение является палиндромом !");
            }
            else Console.WriteLine(" Предложение  не палиндромом ");
            Console.ReadKey();
            #endregion
        }
    }
}
