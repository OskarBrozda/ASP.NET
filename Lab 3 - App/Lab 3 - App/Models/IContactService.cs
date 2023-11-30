using Data.Entities;

namespace Lab_3___App.Models;

public interface IContactService
{
    int Add(Contact contact);
    void Delete(int id);
    void Update(Contact contact);
    List<Contact> FindAll();
    Contact? FindById(int id);
    List<OrganizationEntity> FindAllOrganizations();
}