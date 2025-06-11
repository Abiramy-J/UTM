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
    }
}
