using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicManagementSystem.Models;
using UnicomTicManagementSystem.Repositories;

namespace UnicomTicManagementSystem.Controllers
{
    public static class UserController
    {
        public static bool CreateAdmin(string username, string password)
        {
            using (var conn = DbConfig.GetConnection())
            {
                conn.Open();
                
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                using var checkCmd = new SQLiteCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@Username", username);
                long exists = (long)checkCmd.ExecuteScalar();

                if (exists > 0)
                {
                    return false; // username exists
                }

                string insertQuery = "INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, 'Admin')";
                using var insertCmd = new SQLiteCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@Username", username);
                insertCmd.Parameters.AddWithValue("@Password", password);

                int result = insertCmd.ExecuteNonQuery();
                return result > 0;
            }
        }
        
        public static User Login(string username, string password)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();

            string query = "SELECT * FROM Users WHERE Username = @username AND Password = @password";

            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new User
                {
                    UserId = Convert.ToInt32(reader["UserID"]),
                    Username = reader["Username"].ToString(),
                    Role = reader["Role"].ToString()
                };
            }

            return null; // login failed
        }
        
        public static List<User> GetAllAdmins()
        {
            var admins = new List<User>();
            using var conn = DbConfig.GetConnection();
            conn.Open();

            string query = "SELECT UserID, Username , Password FROM Users WHERE Role = 'Admin'";
            using var cmd = new SQLiteCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                admins.Add(new User
                {
                    UserId = Convert.ToInt32(reader["UserID"]),
                    Username = reader["Username"].ToString() ?? string.Empty,
                    Password = reader["Password"].ToString() ?? string.Empty
                });
            }

            return admins;
        }
        public static bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();

            // Verify user + old password match
            string checkQuery = "SELECT * FROM Users WHERE Username = @uname AND Password = @oldpwd";
            using var cmdCheck = new SQLiteCommand(checkQuery, conn);
            cmdCheck.Parameters.AddWithValue("@uname", username);
            cmdCheck.Parameters.AddWithValue("@oldpwd", oldPassword);

            using var reader = cmdCheck.ExecuteReader();
            if (reader.Read())
            {
                reader.Close(); // must close before updating

                string updateQuery = "UPDATE Users SET Password = @newpwd WHERE Username = @uname";
                using var cmdUpdate = new SQLiteCommand(updateQuery, conn);
                cmdUpdate.Parameters.AddWithValue("@newpwd", newPassword);
                cmdUpdate.Parameters.AddWithValue("@uname", username);

                return cmdUpdate.ExecuteNonQuery() > 0; // true if updated
            }

            return false; // old password incorrect or user not found
        }

        public static bool UsernameExists(string username)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();

            string query = "SELECT COUNT(*) FROM Users WHERE Username = @uname";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@uname", username);

            long count = (long)cmd.ExecuteScalar();
            return count > 0;
        }



    }
}
   
