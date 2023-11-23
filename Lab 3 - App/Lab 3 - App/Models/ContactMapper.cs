using Data.Entities;

namespace Lab_3___App.Models;

public class ContactMapper
{
    public static Contact FromEntity(ContactEntity entity)
    {
        return new Contact()
        {
            Id = entity.ContactId,
            Name = entity.Name,
            Surname = entity.Surname,
            Email = entity.Email,
            Phone = entity.Phone,
            Note = entity.Note,
            Priority = entity.Priority,
            BirthDate = entity.BirthDate,
        };
    }

    public static ContactEntity ToEntity(Contact model)
    {
        return new ContactEntity()
        {
            ContactId = model.Id,
            Name = model.Name,
            Surname = model.Surname,
            Email = model.Email,
            Phone = model.Phone,
            Note = model.Note,
            Priority = model.Priority,
            BirthDate = model.BirthDate,
        };
    }
}