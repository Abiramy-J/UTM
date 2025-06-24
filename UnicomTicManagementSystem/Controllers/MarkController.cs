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
            string query = @"INSERT INTO Marks (StudentID, ExamID, SubjectID, Score,LecturerID) 
                 VALUES (@StudentID, @ExamID, @SubjectID, @Score , @LecturerID)";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@StudentID", mark.StudentID);
            cmd.Parameters.AddWithValue("@ExamID", mark.ExamID);
            cmd.Parameters.AddWithValue("@SubjectID", mark.SubjectID);
            cmd.Parameters.AddWithValue("@Score", mark.Score);
            cmd.Parameters.AddWithValue("@LecturerID", AppSession.LecturerID); 
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
            JOIN Subjects sub ON m.SubjectID = sub.SubjectID
            ";

            using var cmd = new SQLiteCommand(query, conn);
            using var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                marks.Add(new Mark
                {
                    MarkID = Convert.ToInt32(rdr["MarkID"]),
                    StudentName = rdr["StudentName"].ToString() ?? string.Empty,
                    ExamName = rdr["ExamName"].ToString() ?? string.Empty,
                    SubjectName = rdr["SubjectName"].ToString() ?? string.Empty,
                    Score = Convert.ToInt32(rdr["Score"]),

                });
            }

            return marks;
        }
        public static bool MarkExists(int studentId, int examId, string subjectId)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();

            string query = "SELECT COUNT(*) FROM Marks WHERE StudentID = @studentId AND ExamID = @examId AND SubjectID = @subjectId";

            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@studentId", studentId);
            cmd.Parameters.AddWithValue("@examId", examId);
            cmd.Parameters.AddWithValue("@subjectId", subjectId);

            long count = (long)cmd.ExecuteScalar();
            return count > 0;
        }
        // Method to get all marks for the logged-in student
        public static List<Mark> GetMarksForLoggedInStudent()
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
        JOIN Subjects sub ON m.SubjectID = sub.SubjectID
        WHERE s.UserID = @uid";

            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@uid", AppSession.UserId);

            using var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                marks.Add(new Mark
                {
                    MarkID = Convert.ToInt32(rdr["MarkID"]),
                    StudentName = rdr["StudentName"].ToString() ?? string.Empty,
                    ExamName = rdr["ExamName"].ToString() ?? string.Empty,
                    SubjectName = rdr["SubjectName"].ToString() ?? string.Empty,
                    Score = Convert.ToInt32(rdr["Score"])
                });
            }

            return marks;
        }

        // Method 1: Get the course ID of a student
        public static string GetStudentCourseID(int studentID)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();
            string query = "SELECT CourseID FROM Students WHERE StudentID = @StudentID";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@StudentID", studentID);
            var result = cmd.ExecuteScalar();
            return result != null ? result.ToString() : string.Empty;
        }

        // Method 2: Get the subjects for that course
        public static List<Subject> GetSubjectsByCourseID(string courseID)
        {
            var subjectList = new List<Subject>();
            using var conn = DbConfig.GetConnection();
            conn.Open();
            string query = "SELECT * FROM Subjects WHERE CourseID = @CourseID";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@CourseID", courseID);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                subjectList.Add(new Subject
                {
                    SubjectID = reader["SubjectID"].ToString(),
                    SubjectName = reader["SubjectName"].ToString() ?? string.Empty
                });
            }
            return subjectList;
        }
   
    }
}
