using CRUD_ConsoleApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_ConsoleApp
{
    class SchoolService
    {
        private readonly SchoolContext _db;
        public SchoolService(SchoolContext db)
        {
            _db = db;
        }
        public void GetUser()
        {
            var user = _db.Users.ToList();
            foreach (var item in user)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public User CreateUser()
        {
            Console.WriteLine("---Create a user:");
            var user = new User {
                Id = Convert.ToInt32(Console.ReadLine()),
                Name = Console.ReadLine(),
                Age = Convert.ToInt32(Console.ReadLine()),
                Phone = Convert.ToInt32(Console.ReadLine()),
            };
            _db.Add(user);
            _db.SaveChanges();
            return user;
        }
        public void SearchUser(string keyword)
        {
            if ("".Equals(keyword))
            {
                Console.WriteLine("Not found user !!");
            }
            var user = _db.Users.Where(n => n.Id.ToString().Contains(keyword) || n.Name.Contains(keyword)
                                         || n.Age.ToString().Contains(keyword) || n.Phone.ToString().Contains(keyword));
            foreach (var item in user)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
