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
    public static class LecturereController
    {
        public static class LecturerController
        {
            public static string GenerateUsername()
            {
                using var conn = DbConfig.GetConnection();
                conn.Open();
                var cmd = new SQLiteCommand("SELECT COALESCE(MAX(LecturerID), 0) FROM Lecturers", conn);
                long lastID = (long)cmd.ExecuteScalar();
                return "LEC" + (1000 + lastID + 1);
            }

            public static string GeneratePassword()
            {
                var rnd = new Random();
                return "Lect@" + rnd.Next(1000, 9999);
            }

            public static bool CreateLecturer(Lecturer l, string username, string password)
            {
                using var conn = DbConfig.GetConnection();
                conn.Open();

                var userCmd = new SQLiteCommand(
                    "INSERT INTO Users (Username, Password, Role) VALUES (@u, @p, 'Lecturer')", conn);
                userCmd.Parameters.AddWithValue("@u", username);
                userCmd.Parameters.AddWithValue("@p", password);
                userCmd.ExecuteNonQuery();

                long userId = conn.LastInsertRowId;

                var lecCmd = new SQLiteCommand(@"
            INSERT INTO Lecturers (Name, Address, Email, Phone, SubjectID, UserID)
            VALUES (@n, @a, @e, @ph, @s, @u)", conn);

                lecCmd.Parameters.AddWithValue("@n", l.Name);
                lecCmd.Parameters.AddWithValue("@a", l.Address);
                lecCmd.Parameters.AddWithValue("@e", l.Email);
                lecCmd.Parameters.AddWithValue("@ph", l.Phone);
                lecCmd.Parameters.AddWithValue("@s", l.SubjectID);
                lecCmd.Parameters.AddWithValue("@u", userId);

                return lecCmd.ExecuteNonQuery() > 0;
            }

            public static bool UpdateLecturer(Lecturer l)
            {
                using var conn = DbConfig.GetConnection();
                conn.Open();

                var cmd = new SQLiteCommand(@"
            UPDATE Lecturers 
            SET Name=@n, Address=@a, Email=@e, Phone=@ph, SubjectID=@s 
            WHERE LecturerID=@id", conn);

                cmd.Parameters.AddWithValue("@n", l.Name);
                cmd.Parameters.AddWithValue("@a", l.Address);
                cmd.Parameters.AddWithValue("@e", l.Email);
                cmd.Parameters.AddWithValue("@ph", l.Phone);
                cmd.Parameters.AddWithValue("@s", l.SubjectID);
                cmd.Parameters.AddWithValue("@id", l.LecturerID);

                return cmd.ExecuteNonQuery() > 0;
            }

            public static bool DeleteLecturer(int lecturerId)
            {
                using var conn = DbConfig.GetConnection();
                conn.Open();

                var getUser = new SQLiteCommand("SELECT UserID FROM Lecturers WHERE LecturerID = @id", conn);
                getUser.Parameters.AddWithValue("@id", lecturerId);
                var result = getUser.ExecuteScalar();

                if (result == null) return false;

                int userId = Convert.ToInt32(result);

                var delLecturer = new SQLiteCommand("DELETE FROM Lecturers WHERE LecturerID = @id", conn);
                delLecturer.Parameters.AddWithValue("@id", lecturerId);
                delLecturer.ExecuteNonQuery();

                var delUser = new SQLiteCommand("DELETE FROM Users WHERE UserID = @uid", conn);
                delUser.Parameters.AddWithValue("@uid", userId);

                return delUser.ExecuteNonQuery() > 0;
            }

            public static Lecturer GetLecturerById(int lecturerId)
            {
                using var conn = DbConfig.GetConnection();
                conn.Open();

                string query = @"SELECT l.*, u.Username 
                         FROM Lecturers l 
                         JOIN Users u ON l.UserID = u.UserID 
                         WHERE l.LecturerID = @id";

                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", lecturerId);

                using var rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    return new Lecturer
                    {
                        LecturerID = Convert.ToInt32(rdr["LecturerID"]),
                        Name = rdr["Name"].ToString(),
                        Address = rdr["Address"].ToString(),
                        Email = rdr["Email"].ToString(),
                        Phone = rdr["Phone"].ToString(),
                        SubjectID = rdr["SubjectID"].ToString(), // Corrected property name
                        UserID = Convert.ToInt32(rdr["UserID"]),
                        Username = rdr["Username"].ToString()
                    };
                }

                return null;
            }
        }

    }
}
