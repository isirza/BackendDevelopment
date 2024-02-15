using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {


            ArrayList studentAPP = new ArrayList();

            while (true)
            {


                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Lastname :");
                string lastname = Console.ReadLine();
                Console.WriteLine("Age:");
                byte age = Convert.ToByte(Console.ReadLine());

                var student = new { Name = name, Lastname = lastname, Age = age };
                Console.WriteLine(student.Name + "added");

                studentAPP.Add(student);
                Console.WriteLine("1.Do you want to add new student? \n 2. or exit \n  3.Butun telebeleri daxil et 4.remove obcekt");


                byte selection = Convert.ToByte(Console.ReadLine());
                if (selection == 2)
                {
                    break;

                }
                else if (selection == 3)
                {
                    foreach (dynamic item in studentAPP)
                    {
                        Console.WriteLine(item.Name + " " + item.Lastname + "   " + item.Age);
                    }
              


                        Console.ReadLine();

                }

            }
        }
    }
}



       
    
            

