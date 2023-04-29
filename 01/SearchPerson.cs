using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class SearchPerson
    {
        public static void Search(List<People> personList)
        {
            Console.WriteLine("Lütfen arama türünü seçiniz : ");
            Console.WriteLine("İsim veya Soyisim ile arama yapmak için--> (1)");
            Console.WriteLine("Telefon numarası ile arama yapmak için --> (2)");
            int subprocess = int.Parse(Console.ReadLine());

            if (subprocess == 1)
            {
                Console.WriteLine("Lütfen aradığınız kişinin adını veya soyadını giriniz : ");
                string searchedname = Console.ReadLine();

                foreach (People person in personList)
                {
                    if (person.Name.ToLower() == searchedname)
                    {
                        Console.WriteLine("İsim : " + person.Name);
                        Console.WriteLine("Soyisim : " + person.Surname);
                        Console.WriteLine("Telefon Numarası : " + person.Phone);
                        break;
                    }

                    else if (person.Surname.ToLower() == searchedname)
                    {
                        Console.WriteLine("İsim : " + person.Name);
                        Console.WriteLine("Soyisim : " + person.Surname);
                        Console.WriteLine("Telefon Numarası : " + person.Phone);
                        break;
                    }
                }
            }
            else if (subprocess == 2)
            {
                Console.WriteLine("Lütfen aradığınız telefon numarasını giriniz : ");
                string searchednumber = Console.ReadLine();

                foreach (People person in personList)
                {
                    if (person.Phone == searchednumber)
                    {
                        Console.WriteLine("İsim : " + person.Name);
                        Console.WriteLine("Soyisim : " + person.Surname);
                        Console.WriteLine("Telefon Numarası : " + person.Phone);
                        break;
                    }
                }
            }
        }
    }
}
