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
    public static class TimetableController
    {
        public static bool AddTimetable(Timetable t)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();
            var cmd = new SQLiteCommand(@"
            INSERT INTO Timetables (SubjectID, RoomID, Date, TimeSlot)
            VALUES (@s, @r, @d, @t)", conn);

            cmd.Parameters.AddWithValue("@s", t.SubjectID);
            cmd.Parameters.AddWithValue("@r", t.RoomID);
            cmd.Parameters.AddWithValue("@d", t.Date.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@t", t.TimeSlot);

            return cmd.ExecuteNonQuery() > 0;
        }

        public static bool UpdateTimetable(Timetable t)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();
            var cmd = new SQLiteCommand(@"
            UPDATE Timetables SET SubjectID=@s, RoomID=@r, Date=@d, TimeSlot=@t
            WHERE TimetableID=@id", conn);

            cmd.Parameters.AddWithValue("@s", t.SubjectID);
            cmd.Parameters.AddWithValue("@r", t.RoomID);
            cmd.Parameters.AddWithValue("@d", t.Date.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@t", t.TimeSlot);
            cmd.Parameters.AddWithValue("@id", t.TimetableID);

            return cmd.ExecuteNonQuery() > 0;
        }

        public static bool DeleteTimetable(int id)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();
            var cmd = new SQLiteCommand("DELETE FROM Timetables WHERE TimetableID=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            return cmd.ExecuteNonQuery() > 0;
        }

        public static List<Timetable> GetAllTimetables()
        {
            var list = new List<Timetable>();
            using var conn = DbConfig.GetConnection();
            conn.Open();

            string q = @"
            SELECT t.TimetableID, t.Date, t.TimeSlot, 
                   s.SubjectName, r.RoomName
            FROM Timetables t
            JOIN Subjects s ON t.SubjectID = s.SubjectID
            JOIN Rooms r ON t.RoomID = r.RoomID";

            using var cmd = new SQLiteCommand(q, conn);
            using var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                list.Add(new Timetable
                {
                    TimetableID = Convert.ToInt32(rdr["TimetableID"]),
                    Date = Convert.ToDateTime(rdr["Date"]),
                    TimeSlot = rdr["TimeSlot"].ToString(),
                    SubjectName = rdr["SubjectName"].ToString(),
                    RoomName = rdr["RoomName"].ToString()
                });
            }
            return list;
        }
    }
}
