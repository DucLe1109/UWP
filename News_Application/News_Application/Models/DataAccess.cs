using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Windows.Storage;
using System.IO;

namespace News_Application.Models
{
    public class DataAccess
    {
        public async static void InitializeDatabase()
        {
            await ApplicationData.Current.LocalFolder.CreateFileAsync("News.db", CreationCollisionOption.OpenIfExists);
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "News.db");
            using (SqliteConnection db =
               new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS BookMarks (Primary_Key INTEGER PRIMARY KEY, " +
                    "urlToImage text NULL," +
                "author text NULL," +
                "title text NULL," +
                "description text NULL)";

                SqliteCommand createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();
            }
        }
        public static void AddData(string urlToImage, string author,string title,string description)
        {
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "News.db");
            using (SqliteConnection db =
              new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                // Use parameterized query to prevent SQL injection attacks
                insertCommand.CommandText = "INSERT INTO BookMarks VALUES (NULL,@urlToImage,@author,@title,@description);";
                insertCommand.Parameters.AddWithValue("@urlToImage", urlToImage);
                insertCommand.Parameters.AddWithValue("@author", author);
                insertCommand.Parameters.AddWithValue("@title", title);
                insertCommand.Parameters.AddWithValue("@description", description);

                insertCommand.ExecuteReader();

                db.Close();
            }

        }
        
        public static List<Article> GetData()
        {
            List<Article> entries = new List<Article>();

            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "News.db");
            using (SqliteConnection db =
               new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT * from BookMarks", db);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    entries.Add(new Article
                    {
                        urlToImage = query.GetString(1),
                        author = query.GetString(2),
                        title = query.GetString(3),
                        description = query.GetString(4)
                    });
                }

                db.Close();
            }

            return entries;
        }
    }
}
