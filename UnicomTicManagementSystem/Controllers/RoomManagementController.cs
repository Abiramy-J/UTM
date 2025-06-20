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
    public static class RoomManagementController
    {
        public static List<Room> GetAllRooms()
        {
            var list = new List<Room>();
            using var conn = DbConfig.GetConnection();
            conn.Open();

            string query = "SELECT * FROM Rooms";
            using var cmd = new SQLiteCommand(query, conn);
            using var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                list.Add(new Room
                {
                    RoomID = Convert.ToInt32(rdr["RoomID"]),
                    RoomName = rdr["RoomName"].ToString() ?? string.Empty,
                    RoomType = rdr["RoomType"].ToString() ?? string.Empty
                });
            }
            return list;
        }

        public static bool CreateRoom(Room room)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();
            string query = "INSERT INTO Rooms (RoomName, RoomType) VALUES (@name, @type)";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", room.RoomName);
            cmd.Parameters.AddWithValue("@type", room.RoomType);
            return cmd.ExecuteNonQuery() > 0;
        }

        public static bool UpdateRoom(Room room)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();
            string query = "UPDATE Rooms SET RoomName = @name, RoomType = @type WHERE RoomID = @id";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", room.RoomName);
            cmd.Parameters.AddWithValue("@type", room.RoomType);
            cmd.Parameters.AddWithValue("@id", room.RoomID);
            return cmd.ExecuteNonQuery() > 0;
        }

        public static bool DeleteRoom(int roomId)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();
            string query = "DELETE FROM Rooms WHERE RoomID = @id";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", roomId);
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
