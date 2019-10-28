using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SeasonTracker.ViewModels
{
    public class DatabaseHelper
    {
        //defining static so we can easily access without creating a new instance of the class
        private static readonly string databaseName = "SeasonTracker.db";
        private static readonly string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private static readonly string dbFile = Path.Combine(folderPath, databaseName);

        public static bool Insert<T>(T item)
        {
            bool result = false;

            using (SQLiteConnection conn = new SQLiteConnection(dbFile))
            {
                conn.CreateTable<T>();
                int numberOfRows = conn.Insert(item);
                if (numberOfRows > 0)
                    result = true;
            }

            return result;
        }

        public static bool Update<T>(T item)
        {
            bool result = false;

            using (SQLiteConnection conn = new SQLiteConnection(dbFile))
            {
                conn.CreateTable<T>();
                int numberOfRows = conn.Update(item);
                if (numberOfRows > 0)
                    result = true;
            }

            return result;
        }

        public static bool Delete<T>(T item)
        {
            bool result = false;

            using (SQLiteConnection conn = new SQLiteConnection(dbFile))
            {
                conn.CreateTable<T>();
                int numberOfRows = conn.Delete(item);
                if (numberOfRows > 0)
                    result = true;
            }

            return result;
        }
    }
}
