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

        public static bool CreateLecturer(Lecturer l, string username, string password, List<string> subjectIds)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();

            // Step 1: Create User
            var userCmd = new SQLiteCommand("INSERT INTO Users (Username, Password, Role) VALUES (@u, @p, 'Lecturer')", conn);
            userCmd.Parameters.AddWithValue("@u", username);
            userCmd.Parameters.AddWithValue("@p", password);
            userCmd.ExecuteNonQuery();

            long userId = conn.LastInsertRowId;

            // Step 2: Create Lecturer
            var lecCmd = new SQLiteCommand("INSERT INTO Lecturers (Name, Address, Email, Phone, UserID) VALUES (@n, @a, @e, @ph, @u)", conn);
            lecCmd.Parameters.AddWithValue("@n", l.Name);
            lecCmd.Parameters.AddWithValue("@a", l.Address);
            lecCmd.Parameters.AddWithValue("@e", l.Email);
            lecCmd.Parameters.AddWithValue("@ph", l.Phone);
            lecCmd.Parameters.AddWithValue("@u", userId);
            lecCmd.ExecuteNonQuery();

            int lecturerId = (int)conn.LastInsertRowId;

            // Step 3: Assign Subjects (one-by-one, simple style)
            foreach (var subjectId in subjectIds)
            {
                var subCmd = new SQLiteCommand("INSERT INTO LecturerSubjects (LecturerID, SubjectID) VALUES (@lid, @sid)", conn);
                subCmd.Parameters.AddWithValue("@lid", lecturerId);
                subCmd.Parameters.AddWithValue("@sid", subjectId);
                subCmd.ExecuteNonQuery();
            }

            return true;
        }

        public static Lecturer GetLecturerById(int lecturerId)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();

            string query = @"
            SELECT l.*, u.Username, u.Password
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
                    Name = rdr["Name"].ToString() ?? "",
                    Address = rdr["Address"].ToString() ?? "",
                    Email = rdr["Email"].ToString() ?? "",
                    Phone = rdr["Phone"].ToString() ?? "",
                    UserID = Convert.ToInt32(rdr["UserID"]),
                    Username = rdr["Username"].ToString() ?? "",
                    Password = rdr["Password"].ToString() ?? ""
                };
            }

            return null;
        }

        public static bool UpdateLecturer(Lecturer l, List<string> subjectIds)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();

            // Update Lecturer info
            var cmd = new SQLiteCommand("UPDATE Lecturers SET Name=@n, Address=@a, Email=@e, Phone=@ph WHERE LecturerID=@id", conn);
            cmd.Parameters.AddWithValue("@n", l.Name);
            cmd.Parameters.AddWithValue("@a", l.Address);
            cmd.Parameters.AddWithValue("@e", l.Email);
            cmd.Parameters.AddWithValue("@ph", l.Phone);
            cmd.Parameters.AddWithValue("@id", l.LecturerID);
            cmd.ExecuteNonQuery();

            // Clear old subjects
            var delCmd = new SQLiteCommand("DELETE FROM LecturerSubjects WHERE LecturerID = @id", conn);
            delCmd.Parameters.AddWithValue("@id", l.LecturerID);
            delCmd.ExecuteNonQuery();

            // Add updated subjects
            foreach (var sid in subjectIds)
            {
                var subCmd = new SQLiteCommand("INSERT INTO LecturerSubjects (LecturerID, SubjectID) VALUES (@lid, @sid)", conn);
                subCmd.Parameters.AddWithValue("@lid", l.LecturerID);
                subCmd.Parameters.AddWithValue("@sid", sid);
                subCmd.ExecuteNonQuery();
            }

            return true;
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

            // Delete from LecturerSubjects first
            var delSubs = new SQLiteCommand("DELETE FROM LecturerSubjects WHERE LecturerID = @id", conn);
            delSubs.Parameters.AddWithValue("@id", lecturerId);
            delSubs.ExecuteNonQuery();

            // Then delete lecturer
            var delLecturer = new SQLiteCommand("DELETE FROM Lecturers WHERE LecturerID = @id", conn);
            delLecturer.Parameters.AddWithValue("@id", lecturerId);
            delLecturer.ExecuteNonQuery();

            // Then delete user
            var delUser = new SQLiteCommand("DELETE FROM Users WHERE UserID = @uid", conn);
            delUser.Parameters.AddWithValue("@uid", userId);
            delUser.ExecuteNonQuery();

            return true;
        }

        public static List<string> GetLecturerSubjectIds(int lecturerId)
        {
            var list = new List<string>();
            using var conn = DbConfig.GetConnection();
            conn.Open();

            string query = "SELECT SubjectID FROM LecturerSubjects WHERE LecturerID = @id";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", lecturerId);
            using var rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                list.Add(rdr["SubjectID"].ToString() ?? "");
            }

            return list;
        }
        public static Lecturer GetLecturerByUserId(int userId)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();

            string query = @"
        SELECT l.*, u.Username, u.Password
        FROM Lecturers l
        JOIN Users u ON l.UserID = u.UserID
        WHERE l.UserID = @uid";

            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@uid", userId);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Lecturer
                {
                    LecturerID = Convert.ToInt32(reader["LecturerID"]),
                    UserID = Convert.ToInt32(reader["UserID"]),
                    Name = reader["Name"].ToString(),
                    Email = reader["Email"].ToString(),
                    Phone = reader["Phone"].ToString(),
                    Address = reader["Address"].ToString(),
                    
                    Username = reader["Username"].ToString(),
                    Password = reader["Password"].ToString()
                };
            }

            return null;
        }


    }
}
