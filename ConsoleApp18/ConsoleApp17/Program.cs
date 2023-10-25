using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            StringBuilder s = new StringBuilder(Console.ReadLine());
            string s2 = s.ToString();
            Console.Write("Строка без х: ");
            foreach (char a in s2)
            {
                if (a == 'х') { }
                else
                { Console.Write(a); }
            }
            Console.ReadKey();

        }
    }
}
