using Data.Entities;

namespace Lab_3___App.Models;

public interface IOrganizationService
{
    int Add(Organization organization);
    void Delete(int id);
    void Update(Organization organization);
    List<Organization> FindAll();
    Organization? FindById(int id);
}