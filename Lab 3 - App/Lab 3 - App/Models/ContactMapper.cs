using Data.Entities;

namespace Lab_3___App.Models;

public class ContactMapper
{
    public static Contact FromEntity(ContactEntity entity)
    {
        return new Contact
        {
            Id = entity.ContactId,
            Created = entity.Created,
            Name = entity.Name,
            Surname = entity.Surname,
            Email = entity.Email,
            Phone = entity.Phone,
            Note = entity.Note,
            Priority = (Priority)entity.Priority,
            BirthDate = entity.BirthDate,
            OrganizationId = entity.OrganizationId
        };
    }

    public static ContactEntity ToEntity(Contact model)
    {
        return new ContactEntity
        {
            ContactId = model.Id,
            Created = model.Created,
            Name = model.Name,
            Surname = model.Surname,
            Email = model.Email,
            Phone = model.Phone,
            Note = model.Note,
            Priority = (int)model.Priority,
            BirthDate = model.BirthDate,
            OrganizationId = model.OrganizationId,
        };
    }
}