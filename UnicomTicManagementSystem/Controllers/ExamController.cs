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
    public static class ExamController
    {
        public static bool CreateExam(Exam exam)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();

            var query = "INSERT INTO Exams (SubjectID, ExamName, ExamDate) VALUES (@SubjectID, @ExamName, @ExamDate)";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@SubjectID", exam.SubjectID);
            cmd.Parameters.AddWithValue("@ExamName", exam.ExamName);
            cmd.Parameters.AddWithValue("@ExamDate", exam.ExamDate);

            return cmd.ExecuteNonQuery() > 0;
        }

        public static bool UpdateExam(Exam exam)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();

            var query = "UPDATE Exams SET SubjectID = @SubjectID, ExamName = @ExamName, ExamDate = @ExamDate WHERE ExamID = @ExamID";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@SubjectID", exam.SubjectID);
            cmd.Parameters.AddWithValue("@ExamName", exam.ExamName);
            cmd.Parameters.AddWithValue("@ExamDate", exam.ExamDate);
            cmd.Parameters.AddWithValue("@ExamID", exam.ExamID);

            return cmd.ExecuteNonQuery() > 0;
        }

        public static bool DeleteExam(int examId)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();

            var query = "DELETE FROM Exams WHERE ExamID = @ExamID";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@ExamID", examId);

            return cmd.ExecuteNonQuery() > 0;
        }
        public static Exam GetExamById(int examId)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();
            string query = "SELECT * FROM Exams WHERE ExamID = @ExamID";

            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@ExamID", examId);
            using var rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                return new Exam
                {
                    ExamID = Convert.ToInt32(rdr["ExamID"]),
                    SubjectID = rdr["SubjectID"].ToString(),
                    ExamName = rdr["ExamName"].ToString(),
                    ExamDate = Convert.ToDateTime(rdr["ExamDate"])
                };
            }
            return null;
        }


    }
}

