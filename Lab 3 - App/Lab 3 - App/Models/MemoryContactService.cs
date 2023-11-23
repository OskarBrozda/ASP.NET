// namespace Lab_3___App.Models;
//
// public class MemoryContactService : IContactService
// {
//     private Dictionary<int, Contact> _items = new Dictionary<int, Contact>()
//     {
//         {
//             1,
//             new Contact
//             {
//                 Id = 1, Name = "Oskar", Surname = "Karolczyk", BirthDate = new DateTime(2007, 12, 24),
//                 Email = "karolos@mail.com", Phone = "123123123", Priority = Priority.High
//             }
//         },
//         {
//             2,
//             new Contact
//             {
//                 Id = 2, Name = "Tomasz", Surname = "Murawski", BirthDate = new DateTime(2008, 08, 01),
//                 Email = "tmurarz@mail.com", Phone = "091912424", Priority = Priority.Normal
//             }
//         },
//         {
//             3,
//             new Contact
//             {
//                 Id = 3, Name = "Zuzanna", Surname = "Boska", BirthDate = new DateTime(2000, 01, 19),
//                 Email = "boskazuzia@mail.com", Phone = "678998786", Priority = Priority.Low
//             }
//         }
//     };
//     
//     public int Add(Contact item)
//     {
//         int id = _items.Keys.Count != 0 ? _items.Keys.Max() : 0;
//         item.Id = id + 1;
//         _items.Add(item.Id, item);
//         return item.Id;
//     }
//
//     public void Delete(int id)
//     {
//         _items.Remove(id);
//     }
//
//     public List<Contact> FindAll()
//     {
//         return _items.Values.ToList();
//     }
//
//     public Contact? FindById(int id)
//     {
//         return _items[id];
//     }
//
//     public void Update(Contact item)
//     {
//         _items[item.Id] = item;
//     }
// }