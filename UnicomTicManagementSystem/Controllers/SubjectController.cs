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
    public static class SubjectController
    {
        // 🔢 Generate new Subject ID
        public static string GenerateSubjectID()
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();
            var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Subjects", conn);
            long count = (long)cmd.ExecuteScalar();
            return "S" + (1001 + count);
        }
        public static List<Subject> GetAllSubjects()
        {
            var list = new List<Subject>();
            using var conn = DbConfig.GetConnection();
            conn.Open();

            string query = @"
            SELECT s.SubjectID, s.SubjectName, c.CourseName
            FROM Subjects s
            JOIN Courses c ON s.CourseID = c.CourseID";

            var cmd = new SQLiteCommand(query, conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Subject
                {
                    SubjectID = reader["SubjectID"].ToString() ?? string.Empty,
                    SubjectName = reader["SubjectName"].ToString() ?? string.Empty,
                    CourseName = reader["CourseName"].ToString() ?? string.Empty
                });
            }

            return list;
        }

        // ✅ Add a new subject to DB
        public static bool AddSubject(Subject s)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();
            var cmd = new SQLiteCommand("INSERT INTO Subjects (SubjectID, SubjectName, CourseID) VALUES (@id, @name, @cid)", conn);
            cmd.Parameters.AddWithValue("@id", s.SubjectID);
            cmd.Parameters.AddWithValue("@name", s.SubjectName);
            cmd.Parameters.AddWithValue("@cid", s.CourseID);
            return cmd.ExecuteNonQuery() > 0;
        }

        // 🔄 Update subject name + course
        public static bool UpdateSubject(Subject s)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();
            var cmd = new SQLiteCommand("UPDATE Subjects SET SubjectName = @name, CourseID = @cid WHERE SubjectID = @id", conn);
            cmd.Parameters.AddWithValue("@id", s.SubjectID);
            cmd.Parameters.AddWithValue("@name", s.SubjectName);
            cmd.Parameters.AddWithValue("@cid", s.CourseID);
            return cmd.ExecuteNonQuery() > 0;
        }

        // ❌ Delete subject using SubjectID
        public static bool DeleteSubject(string subjectId)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();
            var cmd = new SQLiteCommand("DELETE FROM Subjects WHERE SubjectID = @id", conn);
            cmd.Parameters.AddWithValue("@id", subjectId);
            return cmd.ExecuteNonQuery() > 0;
        }
        public static List<Subject> GetSubjectsForLoggedInLecturer(int lecturerID)
        {
            var subjects = new List<Subject>();
            using var conn = DbConfig.GetConnection();
            conn.Open();

            string query = @"
                SELECT s.SubjectID, s.SubjectName 
        FROM LecturerSubjects ls
        JOIN Subjects s ON ls.SubjectID = s.SubjectID
        WHERE ls.LecturerID = @LecturerID";

            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@LecturerID", lecturerID);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                subjects.Add(new Subject
                {
                    SubjectID = reader["SubjectID"].ToString(),
                    SubjectName = reader["SubjectName"].ToString() ?? string.Empty
                });
            }

            return subjects;
        }
        public static bool IsSubjectExists(string subjectName)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();

            string query = "SELECT COUNT(*) FROM Subjects WHERE LOWER(SubjectName) = @name";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", subjectName.ToLower());

            long count = (long)cmd.ExecuteScalar();
            return count > 0;
        }



    }
}


