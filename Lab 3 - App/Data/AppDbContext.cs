using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class AppDbContext : DbContext
{
    public DbSet<ContactEntity> Contacts { get; set; } 
    private string DbPath { get; set; } 
    public AppDbContext() 
    { 
        var folder = Environment.SpecialFolder.LocalApplicationData; 
        var path = Environment.GetFolderPath(folder); 
        DbPath = System.IO.Path.Join(path, "contacts.db"); 
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options) =>
        options.UseSqlite($"Data Source={DbPath}");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ContactEntity>().HasData(
            new ContactEntity() {
                ContactId = 1, Name = "Oskar", Surname = "Karolczyk", BirthDate = new DateTime(2007, 12, 24),
                Email = "karolos@mail.com", Phone = "123123123", Priority = Priority.High
            },
            new ContactEntity() {
                ContactId = 2, Name = "Tomasz", Surname = "Murawski", BirthDate = new DateTime(2008, 08, 01),
                Email = "tmurarz@mail.com", Phone = "091912424", Priority = Priority.Normal
            },
            new ContactEntity()
            {
                ContactId = 3, Name = "Zuzanna", Surname = "Boska", BirthDate = new DateTime(2000, 01, 19),
                Email = "boskazuzia@mail.com", Phone = "678998786", Priority = Priority.Low
            }
        );
    }
}