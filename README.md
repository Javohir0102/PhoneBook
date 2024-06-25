# PhoneBook
___
PhoneBook App is a simple console application. This application is written in C# and demonstrates basic functionality for ***adding***, ***removing***, and ***viewing*** contacts.
___

### Features
>- Add a new contact with name and phone number
>- Delete a contact by name
>- Show all contacts in the PhoneBook

### Project Structure
ProneBook app is organized three classes
1. **Program.cs**
   ```cs
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
                contactService.AddContact();
                contactService.ShowAllDates();           
            }
        }
    }
3. **Contact.cs** contains Name and Phone properties
   ```cs
       namespace PhoneBook.Model
    {
        internal class Contact
        {
            public string Name { get; set; }
            public string Phone {  get; set; }
        }
    }
4. **ContactSevice.cs** involves all importent methods for instance `AddContact()`, `DeleteContact()`, `CheckValideIndex()` and `ShowAllDates()`.
   - AddContact()
     ![](https://github.com/Javohir0102/PhoneBook/blob/master/PhoneBook/Asset/AddContact.png)

   - DeleteContact()
     ![](https://github.com/Javohir0102/PhoneBook/blob/master/PhoneBook/Asset/DeleteContact().png)

   - CheckValidIndex()
     ![](https://github.com/Javohir0102/PhoneBook/blob/master/PhoneBook/Asset/CheckValideIndex().png)

   - ShowAllDates()
     ![](https://github.com/Javohir0102/PhoneBook/blob/master/PhoneBook/Asset/ShowAllDates().png)


Note: You are in **Version 1** now.
