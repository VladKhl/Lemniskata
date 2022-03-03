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

        public Movie(string namefilm, string year, string country, string genre, string duration, string description, string image, string fragment1, string fragment2, string fragment3, string treiler, string linkfilm)
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
        [NotNull]
        public string Namefilm { get; set; }
        [NotNull]
        public string Year { get; set; }
        [NotNull]
        public string Country { get; set; }
        [NotNull]
        public string Genre { get; set; }
        [NotNull]
        public string Duration { get; set; }
        [NotNull]
        public string Description { get; set; }
        [NotNull]
        public string Image { get; set; }
        [NotNull]
        public string Fragment1 { get; set; }
        [NotNull]
        public string Fragment2 { get; set; }
        [NotNull]
        public string Fragment3 { get; set; }
        [NotNull]
        public string Treiler { get; set; }
        [NotNull]
        public string Linkfilm { get; set; }

    }
}
