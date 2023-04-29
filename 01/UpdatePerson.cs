using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class UpdatePerson
    {
        public static void Update(List<People> personList)
        {
            Console.Write("Lütfen güncellemek istediğiniz kişinin adını veya soyadını giriniz : ");
            string updatedname = Console.ReadLine().ToLower();

            bool control = false;
            while (!control)
            {
                foreach (People person in personList)
                {
                    if (person.Name.ToLower() == updatedname)
                    {
                        Console.Write("Lütfen numarayı girin " + person.Name + ": ");
                        string number = Console.ReadLine();
                        person.Phone = number;
                        control = true;
                        break;
                    }
                    else if (person.Name.ToLower() == updatedname)
                    {
                        Console.Write("Lütfen numarayı girin " + person.Surname + ": ");
                        string number = Console.ReadLine();
                        person.Phone = number;
                        control = true;
                        break;
                    }
                }

                if (!control)
                {
                    Console.WriteLine(" Aradığınız kriterlere uygun kayıt bulunamadı.");
                    Console.WriteLine("* Silme işlemi için   : (1)");
                    Console.WriteLine("* Tekrar deneyin      : (2)");
                    int subprocess = int.Parse(Console.ReadLine());

                    if (subprocess == 1)
                    {
                        control = true;
                    }
                    else if (subprocess == 2)
                    {
                        control = false;
                        Console.Write("Silmek istediğiniz kişinin adını veya soyadını giriniz:: ");
                        updatedname = Console.ReadLine().ToLower();
                    }
                }

            }
        }
    }
}
