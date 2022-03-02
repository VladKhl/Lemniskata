using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Lemniskata.Models
{
    [Table("Films")]
    public class Movie
    {
        public Movie()
        {

        }

        public Movie(string namefilm, int year, string country, string genre, string duration, string description, string image, string fragment1, string fragment2, string fragment3, string treiler, string linkfilm)
        {
            Namefilm = namefilm;
            Year = year;
            Country = country;
            Genre = genre;
            Duration = duration;
            Description = description;
            Image = image;
            Fragment1 = fragment1;
            Fragment2 = fragment2;
            Fragment3 = fragment3;
            Treiler = treiler;
            Linkfilm = linkfilm;
        }

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
        public string Fragment1 { get; set; }
        public string Fragment2 { get; set; }
        public string Fragment3 { get; set; }
        public string Treiler { get; set; }
        public string Linkfilm { get; set; }

    }
}
