using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace task_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 5, 2, 1, 5, 2, 5, 3, 5, 6, 2, 1, 6, 2, 6, 2, 5, 3, 2, 7, 4, 6, 4, 5, 6, 2, 5, 6, 3, 7, 3, 7 };
            int TekrarSayisi = 0;
            foreach (int i in arr)
            {
                if (i == 5)
                {
                    TekrarSayisi++;
                }

            }
            Console.WriteLine("5 arrayda " + TekrarSayisi + " defe tekrarlanib");
            int totalsum = 0;

            foreach (int j in arr)
            {
                totalsum += j;
            }
            Console.WriteLine("Arraydaki butun sayilarin toplami" + "   " + totalsum);
            Console.ReadLine();



            int enBoyuk = arr[0];
            foreach (int i in arr)

            {
                if (i > enBoyuk)
                {
                    enBoyuk = i;


                }
            }
            int tekrar_enBoyuk = 0;
            foreach (int i in arr)
            {
                if (i == enBoyuk)
                {
                    tekrar_enBoyuk++;

                }
            }
            Console.WriteLine("en boyuk eded " + enBoyuk);
            Console.WriteLine("en boyuk eded tekrari" + "   " + tekrar_enBoyuk);

            string name = ("ISMAYIL");
            int herf = 0;

            foreach (var item in name)
            {


                {
                    herf++;

                }



                Console.Write(item);
                Console.WriteLine(herf + " ");


            }


            int[] mrs = { 4, 5, 2, 1, 5, 2, 5, 3, 5, 6, 2, 1, 6, 2, 6, 2, 5, 3, 2, 7, 4, 6, 4, 5, 6, 2, 5, 6, 3, 7, 3, 7 };

            for (int i = 0; i < mrs.Length; i++)
            {
                if (mrs[i] % 3 == 2)
                {
                    Console.WriteLine("qaliqda 2 alinan ededin indeksi" + "  " + i);
                    break;
                }
            }




            int max = mrs[0];
            int maxIndex = 0;
            for(int i = 0; i < mrs.Length; i++)
            {
                if (mrs[i] > max)
                {
                    max = mrs[i];
                    maxIndex = i;
                }

            }
            Console.WriteLine("en boyuk reqem "+"  "+ max);
            Console.WriteLine("index" + " " + maxIndex);
















            Console.ReadLine();
            }
        }
    }

            




        
    

