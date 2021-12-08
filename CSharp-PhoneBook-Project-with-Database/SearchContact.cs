using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PhoneBook_Project_with_Database
{
    public class SearchContact
    {
        internal static void SearchByNameOrSurname(string searchNameOrSurname)
        {
            using (var context = new ContactContext())
            {
                foreach (Contact contact in context.Contacts)
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
        }

        internal static void SearchByNumber(string searchNumber)
        {
            using (var context = new ContactContext())
            {
                foreach (Contact contact in context.Contacts)
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
}
