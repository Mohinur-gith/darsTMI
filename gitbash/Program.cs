using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitbash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 24, b = 36, c = 72, d = 100;
            int ab = ekub(a, b);
            int cd = ekub(c, d);
            int natija = ekub(ab, cd);
            Console.WriteLine("Ekub(a,b) = " + ab + "\nEkub(c,d) = " +cd 
                +"\nEkub = " + natija);
            Console.ReadKey();
        }
        public static int ekub(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return a;
        }
    }
}
