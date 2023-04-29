using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class WritePerson
    {
        public static void Write(List<People> personList)
        {
            foreach (People person in personList)
            {
                Console.WriteLine("İsim: " + person.Name);
                Console.WriteLine("Soyisim: " + person.Surname);
                Console.WriteLine("Telefon Numarası: " + person.Phone);
                Console.WriteLine("-------------------------");
            }
        }
    }
}
