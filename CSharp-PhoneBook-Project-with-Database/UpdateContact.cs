using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PhoneBook_Project_with_Database
{
    public class UpdateContact
    {
        public string UpdatePassedContact(string ContactToBeUpdated, Contact updatedContact)
        {

            using (var context= new ContactContext())
            {
                foreach (Contact contact in context.Contacts)
                {
                    if (ContactToBeUpdated == contact.Name || ContactToBeUpdated == contact.Surname)
                    {
                        contact.Name = updatedContact.Name;
                        contact.Surname = updatedContact.Surname;
                        contact.PhoneNumber = updatedContact.PhoneNumber;
                        context.SaveChanges();
                        return "successfull";
                    }
                }
            }
            return "unsuccessfull";
        }
    }
}
