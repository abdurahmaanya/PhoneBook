using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PhoneBook_Project
{
    public class SearchContact
    {
        internal static void SearchByNameOrSurname(string searchNameOrSurname)
        {
            foreach (Contact contact in PhoneBook.directory)
            {
                if (searchNameOrSurname == contact.Name || searchNameOrSurname == contact.Surname)
                {
                    Console.WriteLine("Name: {0}", contact.Name);
                    Console.WriteLine("Surname: {0}", contact.Surname);
                    Console.WriteLine("PhoneNumber: {0}", contact.PhoneNumber);
                    Console.WriteLine("\n _ \n");
                }
            }
        }

        internal static void SearchByNumber(string searchNumber)
        {
            foreach (Contact contact in PhoneBook.directory)
            {
                if (searchNumber == contact.PhoneNumber)
                {
                    Console.WriteLine("Name: {0}", contact.Name);
                    Console.WriteLine("Surname: {0}", contact.Surname);
                    Console.WriteLine("PhoneNumber: {0}", contact.PhoneNumber);
                    Console.WriteLine("\n _ \n");
                }
            }
        }
    }
}
