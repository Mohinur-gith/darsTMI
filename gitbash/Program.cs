using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitbash
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=24, b=36;
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
            Console.WriteLine("Ekub = " + a);
            Console.ReadKey();
        }
    }
}
