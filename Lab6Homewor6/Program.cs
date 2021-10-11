using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Homewor6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение, знаки препинания не использовать");
            string startString = Console.ReadLine();
            string []stringArray = startString.Split();
            string maxLeght = "";
            int n = 0;
            foreach (string s in stringArray)
            {
                if (s.Length> n)
                {
                    maxLeght = s;
                    n = s.Length;
                }
            }
            Console.WriteLine("Самое длинное слово - {0}", maxLeght);
            Console.ReadKey();

        }
    }
}
