using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PhoneBook_Project
{
    public static class PhoneBook
    {
        public static List<Contact> directory = new List<Contact>();
        
        internal static void AddContact(Contact contact)
        {
            directory.Add(contact);
        }

        internal static void RemoveContact(Contact contact_to_be_deleted)
        {
            directory.Remove(contact_to_be_deleted);
        }
        internal static void UpdateContact(Contact contact_to_be_updated, Contact updatedContact)
        {
            contact_to_be_updated.Name = updatedContact.Name;
            contact_to_be_updated.Surname = updatedContact.Surname;
            contact_to_be_updated.PhoneNumber = updatedContact.PhoneNumber;
        }
    }
}
