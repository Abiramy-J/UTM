using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicManagementSystem.Repositories
{
    public static class DbConfig
    {
        //Connection string points to the correct database file
        private static string connectionString = "Data Source=unicomtic.db;Version=3;";

        // Returns a new SQLiteConnection using that string
        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString); // Clean, reusable connection
        }

    }
}
