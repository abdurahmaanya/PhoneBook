using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PhoneBook_Project_with_Database
{
    public class DeleteContact
    {
        public string DeletePassedContact(string contactToBeDeleted)
        {
            using(var context=new ContactContext())
            {
                foreach (Contact contact in context.Contacts)
                {
                    if (contactToBeDeleted == contact.Name || contactToBeDeleted == contact.Surname)
                    {
                        context.Contacts.Remove(contact);
                        context.SaveChanges();
                        return "successfull";
                    }
                }
            }
            
            return "unsuccessfull";
        }
    }
}
