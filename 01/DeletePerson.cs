using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class DeletePerson
    {
        public static void Delete(List<People> personList)
        {
            Console.Write("Silmek istediğiniz kişinin adını veya soyadını giriniz: ");
            string deletedname = Console.ReadLine().ToLower();
            bool control = false;

            while (!control)
            {
                foreach (People person in personList)
                {
                    if (person.Name.ToLower() == deletedname)
                    {
                        Console.WriteLine(person.Name + " siliniyor, onaylıyormusunuz? (e/h)");
                        char confirmation = char.Parse(Console.ReadLine());

                        if (confirmation == 'e')
                        {
                            personList.Remove(person);
                            Console.WriteLine(person.Name + " silindi.");
                            control = true;
                            break;
                        }
                        else
                        {
                            control = true;
                        }
                    }

                    else if (person.Surname.ToLower() == deletedname)
                    {
                        Console.WriteLine(person.Name + " siliniyor, onaylıyormusunuz? (e/h)");
                        char confirmation = char.Parse(Console.ReadLine());

                        if (confirmation == 'e')
                        {
                            personList.Remove(person);
                            Console.WriteLine(person.Surname + " silindi");
                            control = true;
                            break;
                        }
                        else
                        {
                            control = true;
                        }
                    }

                }

                if (!control)
                {
                    Console.WriteLine("Aradığınız kriterlere uygun kişi bulunamadı.");
                    Console.WriteLine("* Silme işlemi için : (1)");
                    Console.WriteLine("* Tekrar deneyin    : (2)");
                    int subprocess = int.Parse(Console.ReadLine());

                    if (subprocess == 1)
                    {
                        control = true;
                    }
                    else if (subprocess == 2)
                    {
                        control = false;
                        Console.Write("Silmek istediğiniz kişinin adını veya soyadını giriniz: ");
                        deletedname = Console.ReadLine().ToLower();
                    }
                }
            }
        }
    }
}
