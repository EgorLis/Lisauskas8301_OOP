using System;
using System.Collections.Generic;

namespace OOP_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // adding new contacts
            PhoneBook book = new PhoneBook();
            List<Phone> phone_numbers = new List<Phone>();
            phone_numbers.Add(new Phone("944343434", PhoneType.mobile));
            phone_numbers.Add(new Phone("224343434", PhoneType.work));
            book.AddContact("Egor", "Lisauskas", phone_numbers);
            book.AddContact(null, null, null);
            book.AddContact("Ivan", null, null);
            // viewing all numbers
            Console.WriteLine("All contacts: \n");
            List<Contact> all = book.getAllContacts();
            for (int i = 0; i < all.Count; i++)
                Console.WriteLine("{0}: {1}", i + 1, all[i].ToString());
            Console.WriteLine("............................................\n");
            // finding all number with "34"
            List<Contact> finded = book.find("34");
            Console.WriteLine("Finded contacts with '34'\n");
            for (int i = 0; i < finded.Count; i++)
                Console.WriteLine("{0}: {1}\n", i + 1, finded[i].ToString());
            Console.WriteLine("............................................\n");
            // finding all number with "a"
            finded = book.find("a");
            Console.WriteLine("Finded contacts with 'a'\n");
            for (int i = 0; i < finded.Count; i++)
                Console.WriteLine("{0}: {1}\n", i + 1, finded[i].ToString());
            Console.WriteLine("............................................\n");
            // changing contact with index 1 
            phone_numbers = new List<Phone>();
            phone_numbers.Add(new Phone("11111120", PhoneType.work));
            Contact contact_to_change = new Contact("Oleg rabota", null, phone_numbers);
            book.edit(1, contact_to_change);
            Console.WriteLine("All contacts after change: \n");
            all = book.getAllContacts();
            for (int i = 0; i < all.Count; i++)
                Console.WriteLine("{0}: {1}", i + 1, all[i].ToString());
            Console.WriteLine("............................................\n");
            // deleting contact with 'Egor'
            book.RemoveContact("Egor");
            Console.WriteLine("All contacts after deleting contact with 'Egor': \n");
            all = book.getAllContacts();
            for (int i = 0; i < all.Count; i++)
                Console.WriteLine("{0}: {1}", i + 1, all[i].ToString());
            Console.WriteLine("............................................\n");
        }
    }
}
