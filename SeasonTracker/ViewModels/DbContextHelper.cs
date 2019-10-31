using System;
using System.Collections.Generic;
using System.Text;
using SeasonTracker.Models;

namespace SeasonTracker.ViewModels
{
    public class DbContextHelper
    {
        //defining static so we can easily access without creating a new instance of the class
        //private readonly ApplicationDbContext _db;

        //TODO: make this generic somehow?? Right now, can only insert into the Watchlist Db
        public static bool Insert(Watchlist watchlist)
        {
            bool result = false;

            using (ApplicationDbContext _db = new ApplicationDbContext())
            {
                if (_db != null)
                {
                    _db.Watchlists.Add(watchlist);
                    _db.SaveChanges();
                    result = true;
                }
            }

            return result;
        }
    }
}
