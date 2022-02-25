using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Lemniskata.db
{
    [Table("Films")]
    public class Movie
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Unique]
        public string Namefilm { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
        public string Genre { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
