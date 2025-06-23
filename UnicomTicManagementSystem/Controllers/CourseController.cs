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
    public static class CourseController
    {
        // 🔢 Generates a new CourseID like "C1001", "C1002", etc.
        public static string GenerateCourseID()
        {
            using var conn = DbConfig.GetConnection(); // Open database connection
            conn.Open();

            // Count how many courses exist already
            var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Courses", conn);
            long count = (long)cmd.ExecuteScalar();

            // Return new ID based on count (e.g., C1001, C1002...)
            return "C" + (1001 + count);
        }

        // ✅ Adds a new course to the Courses table
        public static bool AddCourse(Course c)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();

            // Insert new course data into the database
            var cmd = new SQLiteCommand("INSERT INTO Courses (CourseID, CourseName) VALUES (@id, @name)", conn);
            cmd.Parameters.AddWithValue("@id", c.CourseID);
            cmd.Parameters.AddWithValue("@name", c.CourseName);

            // Return true if insertion was successful
            return cmd.ExecuteNonQuery() > 0;
        }

        // 🔄 Updates course name based on CourseID
        public static bool UpdateCourse(Course c)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();

            // Update course name where CourseID matches
            var cmd = new SQLiteCommand("UPDATE Courses SET CourseName = @name WHERE CourseID = @id", conn);
            cmd.Parameters.AddWithValue("@id", c.CourseID);
            cmd.Parameters.AddWithValue("@name", c.CourseName);

            return cmd.ExecuteNonQuery() > 0;
        }

        //  Deletes a course using its CourseID
        public static bool DeleteCourse(string courseId)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();

            // Delete the course from the table
            var cmd = new SQLiteCommand("DELETE FROM Courses WHERE CourseID = @id", conn);
            cmd.Parameters.AddWithValue("@id", courseId);

            return cmd.ExecuteNonQuery() > 0;
        }

        //  Gets all courses from the table and returns a list
        public static List<Course> GetAllCourses()
        {
            List<Course> list = new(); // Empty list to store courses

            using var conn = DbConfig.GetConnection();
            conn.Open();

            var cmd = new SQLiteCommand("SELECT * FROM Courses", conn);
            using var rdr = cmd.ExecuteReader();

            // Read each course and add it to the list
            while (rdr.Read())
            {
                list.Add(new Course
                {
                    CourseID = rdr["CourseID"].ToString()?? string.Empty, // Handle nulls gracefully
                    CourseName = rdr["CourseName"].ToString() ?? string.Empty
                });
            }

            return list; // Return full list of courses
        }
        public static bool IsCourseExists(string courseName)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();

            string query = "SELECT COUNT(*) FROM Courses WHERE LOWER(CourseName) = @name";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", courseName.ToLower());

            long count = (long)cmd.ExecuteScalar();
            return count > 0;
        }

    }
}

