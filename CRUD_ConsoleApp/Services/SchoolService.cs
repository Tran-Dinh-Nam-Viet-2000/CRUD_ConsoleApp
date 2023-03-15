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
        public void UpdateUser(int id)
        {
            var queryUser = _db.Users.FirstOrDefault(n => n.Id == id);
            if(queryUser == null)
            {
                Console.WriteLine("Not found user !!");
            }
            else
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                queryUser.Name = name;
                Console.Write("Age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                queryUser.Age = age;
                Console.Write("Phone: ");
                int phone = Convert.ToInt32(Console.ReadLine());
                queryUser.Phone = phone;
                _db.SaveChanges();
                Console.WriteLine("Update successfully !!");
            }
        }
        public void DeleteUser(int id)
        {
            var queryUser = _db.Users.FirstOrDefault(n => n.Id == id);
            if (queryUser == null)
            {
                Console.WriteLine("Not found user !!");
            }
            else
            {
                _db.Remove(queryUser);
                _db.SaveChanges();
                Console.WriteLine("Deleted successfully !!");
            }
        }
    }
}
