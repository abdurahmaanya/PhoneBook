using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PhoneBook_Project
{
    public static class CreateNewContact
    {
        public static void AddNewContact(Contact contact)
        {
            PhoneBook.AddContact(contact);
        }
    }
}
