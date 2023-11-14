using Data.Entities;

namespace Lab3___App.Models
{
    public class ContactMapper
    {
        public static ContactEntity ToEntity(Contact contact)
        {
            return new ContactEntity() 
            {
                First_name = contact.first_name,
                Surname = contact.surname,
                Birth_date = contact.birth_date,
                ContactId = contact.Id,
                OrganizationId = contact.OrganizationId
            };
        }

        public static Contact FromEntity(ContactEntity contact) 
        {
            return new Contact()
            {
                first_name = contact.First_name,
                surname = contact.Surname,
                birth_date = contact.Birth_date,
                Id = contact.ContactId,
                OrganizationId = contact.OrganizationId
            };
        }
    }
}
