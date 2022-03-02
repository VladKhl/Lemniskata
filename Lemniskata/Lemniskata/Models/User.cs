using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Lemniskata.Models
{
    [Table("Client")]
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [NotNull]
        public string Surname { get; set; }
        [NotNull]
        public string Name { get; set; }
        [NotNull]
        [Unique]
        public string Login { get; set; }
        [NotNull]
        public string Password { get; set; }
        [NotNull]
        public string Role { get; set; }
        public string Image { get; set; }

        public User(string surname, string name, string login, string password, string role, string image)
        {
            Surname = surname;
            Name = name;
            Login = login;
            Password = password;
            Role = role;
            Image = image;
        }
        public User()
        {

        }

    }
}
