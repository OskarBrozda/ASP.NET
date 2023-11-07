using Data.Entities;

namespace Lab3___App.Models
{
    public class ContactMapper
    {
        public static ContactEntity ToEntity(Contact contact)
        {
            return new ContactEntity() 
            {
                first_name = contact.first_name,
                surname = contact.surname,
                birth_date = contact.birth_date,
                contactId = contact.Id
            };
        }

        public static Contact FromEntity(ContactEntity contact) 
        {
            return new Contact()
            {
                first_name = contact.first_name,
                surname = contact.surname,
                birth_date = contact.birth_date,
                Id = contact.contactId
            };
        }
    }
}
