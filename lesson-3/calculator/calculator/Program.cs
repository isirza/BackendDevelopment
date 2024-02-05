using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1 ci ededidaxil edin ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2ci ededi daxil edin");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("simvolu daxil edin  + - * / ");
            char sign = Convert.ToChar(Console.ReadLine());


            if(sign=='+')
            {
                Console.WriteLine(x1 + x2);

            }else if(sign=='-')
            {
                Console.WriteLine(x1 - x2);

            }
            else if (sign=='*')

            {
                Console.WriteLine(x1 * x2);


            }
            else if (sign =='/')
            {
                Console.WriteLine(x1 / x2);

            }
            else


            {
                Console.WriteLine("bele bir isare movcud deyildir");
            }
        }
    }
}
