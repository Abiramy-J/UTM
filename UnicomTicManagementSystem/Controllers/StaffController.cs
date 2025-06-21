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
    public static class StaffController
    {
        public static string GenerateUsername()
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();
            var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Users WHERE Role = 'Staff'", conn);
            long count = (long)cmd.ExecuteScalar();
            return "ST" + (1001 + count); // e.g., ST1001
        }

        public static string GeneratePassword()
        {
            return "st" + new Random().Next(1000, 9999); // e.g., st4729
        }

        public static bool AddStaff(Staff staff, string username, string password)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();

            // Insert into Users table first
            var cmdUser = new SQLiteCommand("INSERT INTO Users (Username, Password, Role) VALUES (@u, @p, 'Staff'); SELECT last_insert_rowid();", conn);
            cmdUser.Parameters.AddWithValue("@u", username);
            cmdUser.Parameters.AddWithValue("@p", password);
            var userId = Convert.ToInt32(cmdUser.ExecuteScalar());

            // Insert into Staff table with UserID FK
            var cmdStaff = new SQLiteCommand("INSERT INTO Staffs (FullName, Address, Email, Phone, UserID) VALUES (@f, @a, @e, @ph, @uid)", conn);
            cmdStaff.Parameters.AddWithValue("@f", staff.Name);
            cmdStaff.Parameters.AddWithValue("@a", staff.Address);
            cmdStaff.Parameters.AddWithValue("@e", staff.Email);
            cmdStaff.Parameters.AddWithValue("@ph", staff.Phone);
            cmdStaff.Parameters.AddWithValue("@uid", userId);

            return cmdStaff.ExecuteNonQuery() > 0;
        }

        public static bool UpdateStaff(Staff staff)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();

            var cmd = new SQLiteCommand("UPDATE Staffs SET FullName=@f, Address=@a, Email=@e, Phone=@ph WHERE StaffID=@id", conn);
            cmd.Parameters.AddWithValue("@f", staff.Name);
            cmd.Parameters.AddWithValue("@a", staff.Address);
            cmd.Parameters.AddWithValue("@e", staff.Email);
            cmd.Parameters.AddWithValue("@ph", staff.Phone);
            cmd.Parameters.AddWithValue("@id", staff.StaffID);

            return cmd.ExecuteNonQuery() > 0;
        }
        public static bool DeleteStaff(int staffId)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();

            // Get UserID linked to staff
            var cmdGetUserId = new SQLiteCommand("SELECT UserID FROM Staffs WHERE StaffID=@id", conn);
            cmdGetUserId.Parameters.AddWithValue("@id", staffId);
            var userIdObj = cmdGetUserId.ExecuteScalar();

            if (userIdObj == null) return false;
            int userId = Convert.ToInt32(userIdObj);

            // Delete staff first (FK)
            var cmdDelStaff = new SQLiteCommand("DELETE FROM Staffs WHERE StaffID=@id", conn);
            cmdDelStaff.Parameters.AddWithValue("@id", staffId);
            int staffRows = cmdDelStaff.ExecuteNonQuery();

            // Delete user
            var cmdDelUser = new SQLiteCommand("DELETE FROM Users WHERE UserID=@uid", conn);
            cmdDelUser.Parameters.AddWithValue("@uid", userId);
            int userRows = cmdDelUser.ExecuteNonQuery();

            return staffRows > 0 && userRows > 0;
        }
        public static Staff GetStaffById(int staffId)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();

            var q = @"SELECT s.StaffID, s.FullName, s.Address, s.Email, s.Phone,
                         s.UserID, u.Username , u.Password
                  FROM Staffs s
                  JOIN Users u ON s.UserID = u.UserID
                  WHERE s.StaffID = @id";

            using var cmd = new SQLiteCommand(q, conn);
            cmd.Parameters.AddWithValue("@id", staffId);
            using var rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                return new Staff
                {
                    StaffID = Convert.ToInt32(rdr["StaffID"]),
                    Name = rdr["FullName"].ToString() ?? string.Empty,
                    Address = rdr["Address"].ToString() ?? string.Empty,
                    Email = rdr["Email"].ToString() ?? string.Empty,
                    Phone = rdr["Phone"].ToString() ?? string.Empty,
                    UserID = Convert.ToInt32(rdr["UserID"]),
                    username = rdr["Username"].ToString() ?? string.Empty,
                    password = rdr["Password"].ToString() ?? string.Empty
                };
            }

            return null;
        }

    }
}

