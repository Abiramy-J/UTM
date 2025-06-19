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
    public class MarkController
    {
        public static bool AddMark(Mark mark)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();
            string query = @"INSERT INTO Marks (StudentID, ExamID, Score) 
                         VALUES (@StudentID, @ExamID, @Score)";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@StudentID", mark.StudentID);
            cmd.Parameters.AddWithValue("@ExamID", mark.ExamID);
            cmd.Parameters.AddWithValue("@Score", mark.Score);
            return cmd.ExecuteNonQuery() > 0;
        }
        public static bool UpdateMark(Mark mark)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();
            string query = @"UPDATE Marks SET Score = @Score 
                         WHERE MarkID = @MarkID";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@Score", mark.Score);
            cmd.Parameters.AddWithValue("@MarkID", mark.MarkID);
            return cmd.ExecuteNonQuery() > 0;
        }

        public static bool DeleteMark(int markId)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();
            string query = @"DELETE FROM Marks WHERE MarkID = @MarkID";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@MarkID", markId);
            return cmd.ExecuteNonQuery() > 0;
        }
        public static List<Mark> GetAllMarks()
        {
            var marks = new List<Mark>();
            using var conn = DbConfig.GetConnection();
            conn.Open();
            string query = @"
            SELECT m.MarkID, 
                   s.Name AS StudentName, 
                   e.ExamName, 
                   sub.SubjectName,
                   m.Score
            FROM Marks m
            JOIN Students s ON m.StudentID = s.StudentID
            JOIN Exams e ON m.ExamID = e.ExamID
            JOIN Subjects sub ON e.SubjectID = sub.SubjectID
            ";

            using var cmd = new SQLiteCommand(query, conn);
            using var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                marks.Add(new Mark
                {
                    MarkID = Convert.ToInt32(rdr["MarkID"]),
                    StudentName = rdr["StudentName"].ToString(),
                    ExamName = rdr["ExamName"].ToString(),
                    SubjectName = rdr["SubjectName"].ToString(),
                    Score = Convert.ToInt32(rdr["Score"]),

                });
            }

            return marks;
        }
        public static bool MarkExists(int studentId, int examId)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();
            string query = "SELECT COUNT(*) FROM Marks WHERE StudentID = @studentId AND ExamID = @examId";

            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@studentId", studentId);
            cmd.Parameters.AddWithValue("@examId", examId);

            long count = (long)cmd.ExecuteScalar();
            return count > 0;
        }
        public static List<Mark> GetMarksForLoggedInStudent()
        {
            var marks = new List<Mark>();
            using var conn = DbConfig.GetConnection();
            conn.Open();

            string query = @"
        SELECT m.MarkID, s.Name AS StudentName, e.ExamName, m.Score
        FROM Marks m
        JOIN Students s ON m.StudentID = s.StudentID
        JOIN Exams e ON m.ExamID = e.ExamID
        WHERE s.UserID = @uid";  // <- linking student to user

            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@uid", AppSession.UserId);  // Easy!

            using var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                marks.Add(new Mark
                {
                    MarkID = Convert.ToInt32(rdr["MarkID"]),
                    StudentName = rdr["StudentName"].ToString(),
                    ExamName = rdr["ExamName"].ToString(),
                    Score = Convert.ToInt32(rdr["Score"])
                });
            }

            return marks;
        }


    }
}
