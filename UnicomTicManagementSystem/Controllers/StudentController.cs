using Microsoft.VisualBasic.ApplicationServices;
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
    public static class StudentController
    {
        public static string GenerateUsername()
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();
            // Get the maximum existing StudentID. If no student exists, return 0.
            var cmd = new SQLiteCommand("SELECT COALESCE(MAX(StudentID), 0) FROM Students", conn);
            long lastID = (long)cmd.ExecuteScalar();
            return "UT" + (1000 + lastID + 1);
        }
        public static string GeneratePassword()
        {
            var rnd = new Random();
            return "Stud@" + rnd.Next(1000, 9999);
        }
        public static bool CreateStudent(Student s, string username, string password)
        {
            
            using var conn = DbConfig.GetConnection();
            conn.Open();

            var userCmd = new SQLiteCommand(
                "INSERT INTO Users (Username, Password, Role) VALUES (@u, @p, 'Student')", conn);
            userCmd.Parameters.AddWithValue("@u", username);
            userCmd.Parameters.AddWithValue("@p", password);
            userCmd.ExecuteNonQuery();
            //get the id of the newly inserted user
            long userId = conn.LastInsertRowId;// 
            // Insert student details into Students table
            var stuCmd = new SQLiteCommand(@"
                INSERT INTO Students (Name, Address, Email, Phone, DOB, Gender, CourseID, UserID)
                VALUES (@n, @a, @e, @ph, @dob, @g, @c, @u)", conn);

            stuCmd.Parameters.AddWithValue("@n", s.Name);
            stuCmd.Parameters.AddWithValue("@a", s.Address);
            stuCmd.Parameters.AddWithValue("@e", s.Email);
            stuCmd.Parameters.AddWithValue("@ph", s.Phone);
            stuCmd.Parameters.AddWithValue("@dob", s.DOB);
            stuCmd.Parameters.AddWithValue("@g", s.Gender);
            stuCmd.Parameters.AddWithValue("@c", s.CourseID);
            stuCmd.Parameters.AddWithValue("@u", userId);

            // Return true if the insert was successful (rows affected > 0)
            return stuCmd.ExecuteNonQuery() > 0;


        }
        // Updates an existing student's details
        public static bool UpdateStudents(Student s)
        {
            using var conn = DbConfig.GetConnection(); conn.Open();
            var cmd = new SQLiteCommand(@"
                UPDATE Students SET Name=@n, Address=@a, Email=@e, Phone=@ph, 
                DOB=@dob, Gender=@g, CourseID=@c WHERE StudentID=@id", conn);

            cmd.Parameters.AddWithValue("@n", s.Name);
            cmd.Parameters.AddWithValue("@a", s.Address);
            cmd.Parameters.AddWithValue("@e", s.Email);
            cmd.Parameters.AddWithValue("@ph", s.Phone);
            cmd.Parameters.AddWithValue("@dob", s.DOB);
            cmd.Parameters.AddWithValue("@g", s.Gender);
            cmd.Parameters.AddWithValue("@c", s.CourseID);
            cmd.Parameters.AddWithValue("@id", s.StudentID);

            // Return true if update was successful
            return cmd.ExecuteNonQuery() > 0;
        }
        // Deletes a student and the associated user account
        public static bool DeleteStudents(int studentId)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();

            int userId = -1; //"not yet assigned" placeholder.

            // Get the user id linked to the given studentID
            var getUser = new SQLiteCommand("SELECT UserID FROM Students WHERE StudentID = @id", conn);
            getUser.Parameters.AddWithValue("@id", studentId);
            var result = getUser.ExecuteScalar();//Gets the value from the DB

            if (result == null)//Prevents crash if no result
                return false; 

            userId = Convert.ToInt32(result);//Only happens if result is not null

            // Delete the student from Students table
            var delStu = new SQLiteCommand("DELETE FROM Students WHERE StudentID = @id", conn);
            delStu.Parameters.AddWithValue("@id", studentId);
            delStu.ExecuteNonQuery();

            // Delete the user from Users table
            var delUser = new SQLiteCommand("DELETE FROM Users WHERE UserID = @uid", conn);
            delUser.Parameters.AddWithValue("@uid", userId);

            // Return true if the user was deleted successfully
            return delUser.ExecuteNonQuery() > 0;
        }
        public static Student GetStudentById(int studentId)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();

            string query = @"SELECT s.*, u.Username, u.Password, c.CourseName, c.CourseID
                            FROM Students s
                            JOIN Users u ON s.UserID = u.UserID
                            JOIN Courses c ON s.CourseID = c.CourseID
                            WHERE s.StudentID = @id";

            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", studentId);

            using var rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                return new Student
                {
                    StudentID = Convert.ToInt32(rdr["StudentID"]),
                    Name = rdr["Name"].ToString() ?? string.Empty,
                    Address = rdr["Address"].ToString() ?? string.Empty,
                    Email = rdr["Email"].ToString() ?? string.Empty,
                    Phone = rdr["Phone"].ToString() ?? string.Empty,
                    DOB = Convert.ToDateTime(rdr["DOB"]) ,
                    Gender = rdr["Gender"].ToString() ?? string.Empty,
                    CourseID = rdr["CourseID"].ToString() ?? string.Empty,
                    UserID = Convert.ToInt32(rdr["UserID"]),
                    Username = rdr["Username"].ToString() ?? string.Empty,
                    Password = rdr["Password"].ToString() ?? string.Empty// here you grab password
                };
            }
            return null;
        }

        public static List<Student> GetAllStudents()
        {
            var students = new List<Student>();
            using var conn = DbConfig.GetConnection();
            conn.Open();
            string query = "SELECT StudentID, Name FROM Students";
            using var cmd = new SQLiteCommand(query, conn);
            using var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                students.Add(new Student
                {
                    StudentID = Convert.ToInt32(rdr["StudentID"]),
                    Name = rdr["Name"].ToString() ?? string.Empty
                });
            }
            return students;
        }
        public static Student GetStudentByUserId(int userId)
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();

            string query = @"
        SELECT s.*, u.Username, u.Password, c.CourseName, c.CourseID
        FROM Students s
        JOIN Users u ON s.UserID = u.UserID
        JOIN Courses c ON s.CourseID = c.CourseID
        WHERE s.UserID = @uid";

            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@uid", userId);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Student
                {
                    StudentID = Convert.ToInt32(reader["StudentID"]),
                    UserID = Convert.ToInt32(reader["UserID"]),
                    Name = reader["Name"].ToString() ?? string.Empty,
                    Address = reader["Address"].ToString() ?? string.Empty,
                    Phone = reader["Phone"].ToString() ?? string.Empty,
                    Email = reader["Email"].ToString() ?? string.Empty,
                    Gender = reader["Gender"].ToString() ?? string.Empty,
                    DOB = Convert.ToDateTime(reader["DOB"]),
                    CourseID = reader["CourseID"].ToString() ?? string.Empty,

                    Username = reader["Username"].ToString() ?? string.Empty,
                    Password = reader["Password"].ToString() ?? string.Empty
                };
            }

            return null;
        }




    }
}
