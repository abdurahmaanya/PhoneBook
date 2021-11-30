using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PhoneBook_Project
{
    public class UpdateContact
    {
        //public Contact UpdatedContact { get; set; }
        //public Contact ContactToBeUpdated { get; set; }

        public string UpdatePassedContact(string ContactToBeUpdated, Contact updatedContact)
        {

            foreach (Contact contact in PhoneBook.directory)
            {
                if (ContactToBeUpdated == contact.Name || ContactToBeUpdated == contact.Surname)
                {
                    PhoneBook.UpdateContact(contact, updatedContact);
                    return "successfull";
                }
            }
            return "unsuccessfull";
        }
    }
}
