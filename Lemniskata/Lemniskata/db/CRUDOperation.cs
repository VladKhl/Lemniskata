using Lemniskata.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lemniskata.db
{
    public class CRUDOperation
    {
        SQLiteConnection db;
        public CRUDOperation(string databasePath)
        { 
            db = new SQLiteConnection(databasePath); 
            db.CreateTable<User>();
            db.CreateTable<Movie>();
        }
        public IEnumerable<User> GetUser()
        {
            return db.Table<User>();
        }

        public IEnumerable<Movie> GetMovie()
        {
            return db.Table<Movie>();
        }

        public User GetUserItem(int id)
        {
            return db.Get<User>(id);
        }

        public Movie GetMovieItem(int id)
        {
            return db.Get<Movie>(id);
        }

        public int SaveUser(User user)
        {
            if (user.Id != 0 )
            {
                db.Update(user);
                return user.Id;
            }
            else
            {
                return db.Insert(user);
            }
        }

        public int SaveMov(Movie mov)
        {
            if (mov.Id != 0)
            {
                db.Update(mov);
                return mov.Id;
            }
            else
            {
                return db.Insert(mov);
            }
        }

    }
}
