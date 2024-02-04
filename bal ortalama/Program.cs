using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bal_ortalama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("imtahan giris balini girin");
            Console.WriteLine("imtahan balini girin");
            int giris_bali = Convert.ToInt32(Console.ReadLine());
            if (giris_bali < 17)
            {
                Console.WriteLine("F"+  "   "+ "kesildin aslan parcasi");
            }
            else
            {

            }
        
         
            if(giris_bali>=51)
            {
                Console.WriteLine("giris balini duzgun daxil et");
            }
            else
            {

            }
            int imtahan_bali = Convert.ToInt32(Console.ReadLine());
            if (imtahan_bali<17)
            {
                Console.WriteLine("F"+ "   "+ "KESILDIN");
            }
            else
            {

            }
            if (imtahan_bali>50)
            {
                Console.WriteLine("duzgun daxil et");
            }
            else
            {

            }
            int yekun_bal = (giris_bali + imtahan_bali);

            


          

    

            if (yekun_bal >= 91 && yekun_bal <= 100)
            {
                Console.WriteLine("bal dereceniz : A ");

            }

            else if (yekun_bal >= 81 && yekun_bal <= 90)
            {
                Console.WriteLine("bal dereceniz : B ");

            }
            else if (yekun_bal >= 71 && yekun_bal <= 80)
            {
                Console.WriteLine("bal dereceniz : C ");

            }
            else if (yekun_bal >= 61 && yekun_bal <= 70)
            {
                Console.WriteLine("bal dereceniz : D" );

            }
            else if (yekun_bal >= 51 && yekun_bal <= 60)
            {
                Console.WriteLine("bal dereceniz : E" );

            }
            else if (yekun_bal >= 1 && yekun_bal <= 50 )
            {
                Console.WriteLine("bal dereceniz : F" +   " kesildin aslan parcasi ");

            }
            else
            {
                
            }
        }
    }
}
