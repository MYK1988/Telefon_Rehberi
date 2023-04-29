using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
   
    
        class AddPerson
        {
            public static void Add(List<People> personList)
            {
                Console.Write("İsim Giriniz : ");
                string name = Console.ReadLine();
                Console.Write("Soyadını Giriniz : ");
                string surname = Console.ReadLine();
                Console.Write("Telefon Numarasını Giriniz : ");
                string phone = Console.ReadLine();


                Console.WriteLine("*********************");

                People person = new People { Name = name, Surname = surname, Phone = phone };
                Book.personList.Add(person);
            }
        }
 }
