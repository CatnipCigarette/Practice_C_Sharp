using System;
using System.Collections.Generic;

namespace MySpase
{
    class Contact
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }

        public Contact(string lastName, string firstName, string middleName, DateTime birthDate, string phoneNumber)
        {
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            BirthDate = birthDate;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $"{LastName} {FirstName} {MiddleName} - {BirthDate.ToShortDateString()} - {PhoneNumber}";
        }
    }

    class Notebook
    {
        private List<Contact> contacts = new List<Contact>();

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

        public void RemoveContact(Contact contact)
        {
            contacts.Remove(contact);
        }

        public void ShowContacts()
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }

        public void PrintContacts()
        {
            foreach (Contact contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }

        public List<Contact> SearchContacts(string query)
        {
            List<Contact> result = new List<Contact>();

            foreach (Contact contact in contacts)
            {
                if (contact.LastName.Contains(query) || contact.FirstName.Contains(query) || contact.MiddleName.Contains(query) || contact.PhoneNumber.Contains(query))
                {
                    result.Add(contact);
                }
            }

            return result;
        }


        public int GetCount()
        {
            return contacts.Count;
        }

        public int FindIndex(string lastName, string firstName, string middleName, DateTime birthDate, string phoneNumber)
        {
            for (int i = 0; i < contacts.Count; i++)
            {
                var contact = contacts[i];
                if (contact.LastName == lastName &&
                    contact.FirstName == firstName &&
                    contact.MiddleName == middleName &&
                    contact.BirthDate == birthDate &&
                    contact.PhoneNumber == phoneNumber)
                {
                    return i;
                }
            }
            return -1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            int n = 0;

            while (n < 9)
            {
                Console.WriteLine("Введите данные контакта: ");
                Console.Write("Фамилия: ");
                string lastName = Console.ReadLine();

                Console.Write("Имя: ");
                string firstName = Console.ReadLine();

                Console.Write("Отчество: ");
                string middleName = Console.ReadLine();

                Console.Write("Дата рождения (в формате ДД.ММ.ГГГГ): ");
                DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);

                Console.Write("Номер телефона: ");
                string phoneNumber = Console.ReadLine();

                Contact contact = new Contact(lastName, firstName, middleName, birthDate, phoneNumber);
                notebook.AddContact(contact);
                Console.WriteLine();
                n++;
            }

            Console.Write("Введите запрос: ");
            string query = Console.ReadLine();

            List<Contact> searchResult = notebook.SearchContacts(query);

            if (searchResult.Count == 0)
            {
                Console.WriteLine("Контакты не найдены.");
            }
            else
            {
                Console.WriteLine($"Результаты поиска ({searchResult.Count}):");
                foreach (var contact in searchResult)
                {
                    Console.WriteLine(contact);
                }
            }
            Console.WriteLine();

            Console.Write("Введите запрос для удаления: ");
            string queryDel = Console.ReadLine();

            List<Contact> searchResultDel = notebook.SearchContacts(queryDel);

            if (searchResultDel.Count == 0)
            {
                Console.WriteLine("Контакты не найдены.");
            }
            else
            {
                foreach (var contactdel in searchResultDel)
                {
                    notebook.RemoveContact(contactdel);
                    Console.Write(contactdel);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" -- УДАЛЕНО");
                    Console.ResetColor();
                }
            }
            Console.WriteLine();

            Console.WriteLine("Все контакты:");
            notebook.ShowContacts();

        }
    }
}