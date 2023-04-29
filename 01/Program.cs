
using _01;

            Console.WriteLine("(1) Kişi Eklemek İçin");
            Console.WriteLine("(2) Kişi Silmek İçin");
            Console.WriteLine("(3) Kişi Güncellemek İçin");
            Console.WriteLine("(4) Kişileri Listelemek İçin");
            Console.WriteLine("(5) Arama Yapmak İçin");
            Console.WriteLine("(0) Kapat");

            Console.WriteLine("**********************");
            Console.Write("Yapmak istediğiniz işlemin numnarasını giriniz : ");
            int process = int.Parse(Console.ReadLine());
            Console.WriteLine("**********************");
            Book book = new Book();

            bool control = true;
            while (control)
            {
                switch (process)
                {
                    case 1:
                        AddPerson.Add(Book.personList);
                        break;

                    case 2:
                        DeletePerson.Delete(Book.personList);
                        break;

                    case 3:
                        UpdatePerson.Update(Book.personList);
                        break;

                    case 4:
                        WritePerson.Write(Book.personList);
                        break;

                    case 5:
                        SearchPerson.Search(Book.personList);
                        break;

                    case 0:
                        control = false;
                        break;

                    default:
                        Console.WriteLine("Hatalı Tuşlama Yaptınız");
                        break;
                }


                if (control)
                {
                    Console.Write("Tekrar Deneyiniz ");
                    process = int.Parse(Console.ReadLine());
                    Console.WriteLine("**********************");
                }
            }

            Console.ReadKey();
