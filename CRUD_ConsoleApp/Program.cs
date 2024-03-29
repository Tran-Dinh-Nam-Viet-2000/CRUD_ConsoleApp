﻿using CRUD_ConsoleApp.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;

namespace CRUD_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Choose funtion------");
            Console.WriteLine("1. Add a new user");
            Console.WriteLine("2. Show all Customer");
            Console.WriteLine("3. Search Customer");
            Console.WriteLine("4. Update Customer");
            Console.WriteLine("5. Remove Customer");
            Console.WriteLine("6. Exit");
            Console.Write("Choose your number: ");
            SchoolContext dbContext = new SchoolContext();
            SchoolService schoolService = new SchoolService(dbContext);
            while (true)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        schoolService.CreateUser();
                        break;
                    case 2:
                        schoolService.GetUser();
                        break;
                    case 3:
                        Console.Write("--Search user: ");
                        string keyword = Console.ReadLine();
                        schoolService.SearchUser(keyword);
                        break;
                    case 4:
                        Console.Write("--Enter user by id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        schoolService.UpdateUser(id);
                        break;
                    case 5:
                        Console.Write("--Enter user by id: ");
                        int userId = Convert.ToInt32(Console.ReadLine());
                        schoolService.DeleteUser(userId);
                        break;
                }
                if (number >= 6)
                {
                    Console.WriteLine("Exit program !!");
                    break;
                }
            }
            
        }

        
    }
}
