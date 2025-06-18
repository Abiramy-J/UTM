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
    public  class MarkController
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
            string query = @"SELECT MarkID, StudentID, ExamID, Score FROM Marks";
            using var cmd = new SQLiteCommand(query, conn);
            using var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                marks.Add(new Mark
                {
                    MarkID = Convert.ToInt32(rdr["MarkID"]),
                    StudentID = rdr["StudentID"].ToString(),
                    ExamID = Convert.ToInt32(rdr["ExamID"]),
                    Score = Convert.ToInt32(rdr["Score"])
                });
            }
            return marks;
        }

    }
}
