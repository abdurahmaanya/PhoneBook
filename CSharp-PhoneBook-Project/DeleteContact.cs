using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PhoneBook_Project
{
    public class DeleteContact
    {
        
        public string DeletePassedContact(string contactToBeDeleted)
        {

            foreach (Contact contact in PhoneBook.directory)
            {
                if (contactToBeDeleted == contact.Name || contactToBeDeleted == contact.Surname)
                {
                    PhoneBook.RemoveContact(contact);
                    return "successfull";
                }
            }
            return "unsuccessfull";
        }
    }
}
