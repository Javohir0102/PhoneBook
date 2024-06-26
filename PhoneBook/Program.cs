using PhoneBook.Model;
using PhoneBook.ContactServices;
using System.Collections.Generic;
using System;

namespace PhoneBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContactService contactService = new ContactService();
            contactService.PopulateContacts();
            contactService.ShowMenu();         
        }
    }
}
