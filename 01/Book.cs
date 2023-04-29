using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
   class Book
    {
        public static List<People> personList = new List<People>();


        public Book()
        {
            People person1 = new People { Name = "Ali", Surname = "Sunal", Phone = "05441234567" };
            People person2 = new People { Name = "Berk", Surname = "Kaya", Phone = "05421234567" };
            People person3 = new People { Name = "Cemal", Surname = "Sert", Phone = "03221234567" };
            People person4 = new People { Name = "Derya", Surname = "Lale", Phone = "03456789786" };
            People person5 = new People { Name = "Emel", Surname = "Erol", Phone = "03454376575" };

            personList.Add(person1);
            personList.Add(person2);
            personList.Add(person3);
            personList.Add(person4);
            personList.Add(person5);
        }
    }
}
