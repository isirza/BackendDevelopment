using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1ci ededi daxil edin");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2ci ededi daxil edin");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("simvolu  daxil edin + - * /");
            char sign = Convert.ToChar(Console.ReadLine());
           
            switch (sign)
            {
                            
            case '+':
            Console.WriteLine($"{x1} {sign} {x2} = {x1 + x2}");
            break;



            case '-':
            Console.WriteLine($"{x1} {sign} {x2} = {x1 - x2}");
            break;



            case '*':
                    Console.WriteLine($"{x1} {sign} {x2} = {x1 * x2}");
            break;



            case '/':
                    Console.WriteLine($"{x1} {sign} {x2} = {x1 / x2}");
                        
            break;





            }
       


        }
    }
}
