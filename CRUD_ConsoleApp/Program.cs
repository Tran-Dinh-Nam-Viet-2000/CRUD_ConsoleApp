using CRUD_ConsoleApp.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;

namespace CRUD_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolContext db = new SchoolContext();
            School school = new School(db);
            school.GetUser();
        }

        
    }
}
