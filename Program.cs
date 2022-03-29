using System;

namespace ConsoleAppPhoneBookContacts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        private static void Run()
        {
            var phoneBook = new PhoneBook();
            bool check = false;
            Console.WriteLine("Welcome to my phone book!");
            
            while (!check)
            {
                Console.WriteLine("");
                Console.WriteLine("Select Operation:");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Display Contact by Number");
                Console.WriteLine("3. View All Contacts");
                Console.WriteLine("4. Display Contact by Name");
                Console.WriteLine("5. Exit");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Contact name: ");
                        string contactName = Console.ReadLine();
                        Console.Write("Contact number: ");
                        string contactNumber = Console.ReadLine();

                        var newContact = new Contact(contactName, contactNumber);
                        phoneBook.AddContact(newContact);
                        break;

                    case "2":
                        Console.Clear();
                        Console.Write("Number: ");
                        string searchNumber = Console.ReadLine();
                        phoneBook.DisplayContactByNumber(searchNumber);
                        break;

                    case "3":
                        Console.Clear();
                        phoneBook.DisplayAllContacts();
                        break;

                    case "4":
                        Console.Clear();
                        Console.Write("Name: ");
                        string searchName = Console.ReadLine();
                        phoneBook.DisplayContactByName(searchName);
                        break;

                    default:
                        Console.Write("Exiting...");
                        check = true;
                        break;
                }
            }
        }
    }
}