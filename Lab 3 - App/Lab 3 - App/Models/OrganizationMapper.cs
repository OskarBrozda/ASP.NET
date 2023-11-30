using Data;
using Data.Entities;

namespace Lab_3___App.Models;

public abstract class OrganizationMapper
{
    public static Organization FromEntity(OrganizationEntity entity)
    {
        return new Organization
        {
            OrganizationId = entity.OrganizationId,
            Title = entity.Title,
            Description = entity?.Description,
            Nip = entity.Nip,
            Regon = entity.Regon,
            Address = entity.Address
        };
    }

    public static OrganizationEntity ToEntity(Organization model)
    {
        return new OrganizationEntity
        {
            OrganizationId = model.OrganizationId,
            Description = model?.Description,
            Title = model.Title,
            Nip = model.Nip,
            Regon = model.Regon,
            Address = model.Address
        };
    }
}