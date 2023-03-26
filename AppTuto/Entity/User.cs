using System;
using SQLite;
using System.Collections.Generic;
using System.Text;

namespace AppTuto.Entity
{
    [Table("")]
    public class User
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        [MaxLength(100),Unique ]
        public string Name { get; set; }
    }
}
