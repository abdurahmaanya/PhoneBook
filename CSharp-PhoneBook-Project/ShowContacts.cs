using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PhoneBook_Project
{
    public  class ShowContacts
    {
        public ShowContacts()
        {
            foreach (Contact contact in PhoneBook.directory)
            {
                Console.WriteLine("Name         : {0}", contact.Name);
                Console.WriteLine("Surname      : {0}", contact.Surname);
                Console.WriteLine("PhoneNumber  : {0}", contact.PhoneNumber);
                Console.WriteLine("\n _ \n");
            }
        }
    }
}
