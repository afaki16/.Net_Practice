using System;
using System.Collections.Generic;

namespace Proje_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contacts> phoneContact = new List<Contacts>();
            contactSolutions contactSolutions = new contactSolutions();
            phoneContact.Add(new Contacts("Alperen", "Fakı", 24589545));
            phoneContact.Add(new Contacts("Ahmet", "Yılmaz", 23654785));
            phoneContact.Add(new Contacts("Mehmet", "Şen", 14523698));
            phoneContact.Add(new Contacts("Merve", "Zambak", 47852396));
            phoneContact.Add(new Contacts("Hazal", "Arıcı", 89631244));

            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: ");
            Console.WriteLine("******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncellemek");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            Console.WriteLine("(6) İşlemden çıkış");
            int islem = int.Parse(Console.ReadLine());

             switch (islem)
             {
                 case 1:
                        contactSolutions.Add(phoneContact);
                        break;
                    case 2:
                        contactSolutions.Delete(phoneContact);
                        break;
                    case 3:
                        contactSolutions.Lists(phoneContact);
                        break;
                    case 4:
                        contactSolutions.Update(phoneContact);
                        break;
                    case 5:
                        contactSolutions.Find(phoneContact);
                        break;
                    case 6:
                        Console.WriteLine("İşlemden çıkış.");
                        break;
             }






        }
    }
}