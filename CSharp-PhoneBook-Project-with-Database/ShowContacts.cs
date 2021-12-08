using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PhoneBook_Project_with_Database
{
    public class ShowContacts
    {
        public ShowContacts()
        {
            using (var context = new ContactContext())
            {
                foreach (Contact contact in context.Contacts)
                {
                    Console.WriteLine("Name         : {0}", contact.Name);
                    Console.WriteLine("Surname      : {0}", contact.Surname);
                    Console.WriteLine("PhoneNumber  : {0}", contact.PhoneNumber);
                    Console.WriteLine("\n _ \n");
                }
            }
        }
    }
}
