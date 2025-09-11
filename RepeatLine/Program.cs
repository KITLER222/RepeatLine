using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string line = Console.ReadLine();

            Console.WriteLine("Введите сколько раз будет повторятся строка");
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine(Repeat(line, count));
        }

        public static string Repeat(string s, int count)
        {
            string res = "";
            for (int i = 0; i < count; i++)
            {
                res += s;
                if (i < count - 1)
                {
                    res += " ";
                }
            }
            return res;
        }
    }
}
