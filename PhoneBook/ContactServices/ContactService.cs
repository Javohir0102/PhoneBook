using PhoneBook.Model;
using System;
using System.Reflection;

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
            Console.Write("Nechanchi indexga contact qo'shasiz: ");
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

        public void EditContact()
        {
            ShowAllContacts();
            Console.Write("Yuqoridagi ro'yxatdagi nechanchi indexni telefon raqamini o'zgartirmoqchisiz: ");
            var index = CheckValideIndex();
/*            Console.Write("Ism kiriting: ");
            var name = Console.ReadLine();*/
            Console.Write("Yangi raqamini kiriting: ");
            var phone = Console.ReadLine();

            contacts[index].Phone = phone;
            Console.WriteLine("Contact edited successfully!");
        }

        public void ShowMenu()
        {
            Console.WriteLine("Welcome to the Phone Book app");
            do
            {
                Console.WriteLine();
                Console.WriteLine("1. view all contacts");
                Console.WriteLine("2. add contact");
                Console.WriteLine("3. edit contact");
                Console.WriteLine("4. delete contact");
                Console.Write("Select one of the menu (click any number 1, 2, 3, 4): ");
                SelectMenu();

            } while (true);
        }

        private void SelectMenu()
        {
            int inputNumber = 0;
            var isInputNumber = int.TryParse(Console.ReadLine(), out inputNumber);
            if (!isInputNumber)
            {
                Console.Write("please select (number) again correctly: ");
                return;
            }
            switch (inputNumber)
            {
                case 1: 
                    ShowAllContacts();
                    break;
                case 2: 
                    AddContact();
                    break;
                case 3:
                    EditContact();
                    break;
                case 4:
                    DeleteContact();
                    break;
                default:
                    Console.WriteLine("select only these (1, 2, 3, 4)");
                    break;
            };
        }

        public void ShowAllContacts()
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
