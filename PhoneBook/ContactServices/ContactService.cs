using PhoneBook.Model;
using System;

namespace PhoneBook.ContactServices
{
    internal class ContactService
    {
        private Contact[] contacts = new Contact[10];
        public void PopulateContacts()
        {
            contacts[0] = new Contact
            {
                Name = "Javohir",
                Phone = "1223311"
            };
            contacts[1] = new Contact()
            {
                Name = "Alishe",
                Phone = "5544554"
            };
            contacts[2] = new Contact()
            {
                Name = "",
                Phone = ""
            };
            contacts[3] = new Contact()
            {
                Name = "",
                Phone = ""
            };
            contacts[4] = new Contact()
            {
                Name = "",
                Phone = ""
            };
            contacts[5] = new Contact()
            {
                Name = "",
                Phone = ""
            };
            contacts[6] = new Contact()
            {
                Name = "",
                Phone = ""
            };
            contacts[7] = new Contact()
            {
                Name = "",
                Phone = ""
            };
            contacts[8] = new Contact()
            {
                Name = "",
                Phone = ""
            };
            contacts[9] = new Contact()
            {
                Name = "",
                Phone = ""
            };
        }
        public void AddContact()
        {
            var index = CheckValideIndex();
            Console.Write("Ism kiriting: ");
            var name = Console.ReadLine();
            Console.Write("Telefon raqam kiriting: ");
            var phone = Console.ReadLine();
            Contact contact = new Contact() { Name = name, Phone = phone };

            contacts[index] = contact;
            Console.WriteLine("Contact added successfully!");
        }
        public void DeleteContact()
        {
            var index = CheckValideIndex();
            Contact contact = new Contact() { Name = "", Phone = string.Empty };

            contacts[index] = contact;
            Console.WriteLine("Contact deleted successfully!");
        }
        public int CheckValideIndex()
        {
            int index = 0;
            var isIndexValid = false;
            Console.Write("Nechanchi indexga contact qo'shasiz: ");
            while (!isIndexValid)
            {
                isIndexValid = int.TryParse(Console.ReadLine(), out index);
                if (!isIndexValid || index < 0 || index > 9)
                {
                    isIndexValid = false;
                    Console.Write("index xato kiritildi!\nIndexni qayta kiriting: ");
                }
            }
            return index;
        }
        public void ShowAllDates()
        {
            int i = 1;
            foreach (Contact contact in contacts)
            {
                Console.WriteLine($"{i}. Name: {contact.Name}, PhoneNumber: {contact.Phone} ");
                i++;
            }
        }
    }
}
