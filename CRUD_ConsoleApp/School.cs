using CRUD_ConsoleApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_ConsoleApp
{
    class School
    {
        private readonly SchoolContext _db;
        public School(SchoolContext db)
        {
            _db = db;
        }
        public void GetUser()
        {
            var user = _db.Users.ToList();
            foreach (var item in user)
            {
                Console.WriteLine(item.Id + "\t" + item.Name + "\t" + item.Age + "\t" + item.Phone);
            }
        }
    }
}
