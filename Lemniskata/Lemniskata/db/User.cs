using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Lemniskata.db
{
    [Table("Client")]
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Unique]
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
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
