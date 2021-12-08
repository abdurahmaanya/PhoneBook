using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PhoneBook_Project_with_Database
{
    public static class CreateNewContact
    {
        public static void AddNewContact(Contact contact)
        {
            using(var context=new ContactContext())
            {
                context.Contacts.Add(contact);
                context.SaveChanges();
            }
        }
    }
}
