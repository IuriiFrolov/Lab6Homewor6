using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {// Удаляет текст вместе с { }
            Console.WriteLine("Введите строку S");
            string stringS = Console.ReadLine();
            
            for ( int i = 0, j = 0, a = 0; i < stringS.Length; i++)
            {
                if (stringS[i] == '{')
                { j++; if (j == 1) a = i; }
                else
               if ((stringS[i] == '}') && (j != 0))
                {
                    j--;
                    if (j == 0)
                    {
                        stringS = stringS.Remove(a, i - a + 1);
                        i -= i - a + 1;
                    }
                }
            }
            Console.Write(stringS);
            Console.ReadKey();
        }
    }
}
