using System;
using System.Collections.Generic;

#nullable disable

namespace CRUD_ConsoleApp.Entities
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public int? Phone { get; set; }
    }
}
