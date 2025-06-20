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
        public static List<User> GetAllAdmins()
        {
            var admins = new List<User>();
            using var conn = DbConfig.GetConnection();
            conn.Open();

            string query = "SELECT UserID, Username FROM Users WHERE Role = 'Admin'";
            using var cmd = new SQLiteCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                admins.Add(new User
                {
                    UserId = Convert.ToInt32(reader["UserID"]),
                    Username = reader["Username"].ToString() ?? string.Empty
                });
            }

            return admins;
        }

        public static string Login(string username, string password)
        {
            using (var conn = DbConfig.GetConnection())
            {
                conn.Open();
                string query = "SELECT UserID, Role FROM Users WHERE Username = @Username AND Password = @Password";
                using var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                using var reader = cmd.ExecuteReader();

                if (reader.Read())
                { 
                    AppSession.UserId = Convert.ToInt32(reader["UserID"]);
                    AppSession.Role = reader["Role"].ToString() ?? string.Empty;

                    //  If it's a student, set the StudentID also:
                    if (AppSession.Role == "Student")
                    {
                        AppSession.StudentID = StudentController.GetStudentIDByUserId(AppSession.UserId);
                    }

                    return AppSession.Role; // 👈 return it so you know where to redirect
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
