using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using Windows.Storage;
using System.IO;
using System.Data;

namespace Practical_TEST.Models
{
    public class DataAccess
    {
        public async static void InitializeDatabase()
        {
            await ApplicationData.Current.LocalFolder.CreateFileAsync("practical_TEST.db", CreationCollisionOption.OpenIfExists);
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "practical_TEST.db");
            using (SqliteConnection db =
               new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS Contact (Primary_Key INTEGER PRIMARY KEY, " +
                    "name text NULL," +
                    "phoneNumber text NULL)";

                SqliteCommand createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();
            }
        }
        public static void AddData(string name,string phoneNumber)
        {
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "practical_TEST.db");
            using (SqliteConnection db =
              new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                // Use parameterized query to prevent SQL injection attacks
                insertCommand.CommandText = "INSERT INTO Contact VALUES (NULL, @name,@phoneNumber);";
                insertCommand.Parameters.AddWithValue("@name", name);
                insertCommand.Parameters.AddWithValue("@phoneNumber", phoneNumber);

                insertCommand.ExecuteReader();

                db.Close();
            }

        }
        public static List<Contact> GetData(String name_search)
        {
            string abc = name_search;
            List<Contact> entries = new List<Contact>();

            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "practical_TEST.db");
            using (SqliteConnection db =
               new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT * from Contact" + "where name = @name_search", db);
                selectCommand.Parameters.Add("@name_search", (SqliteType)SqlDbType.Text);
                selectCommand.Parameters["@name_search"].Value = name_search;

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    entries.Add(new Contact { 
                    name = query.GetString(1),
                    phoneNumber = query.GetString(2)
                    });
                }

                db.Close();
            }

            return entries;
        }
    }
}
