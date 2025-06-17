using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicManagementSystem.Repositories
{
    /*public static class SystemDefaults
    {
        // This method seeds default courses and subjects into the database
        // but only if the Courses table is empty (to avoid duplicate inserts).
        public static void SeedDefaultCoursesAndSubjects(SQLiteConnection conn)
        {
            // Check how many courses are currently in the Courses table
            var countCmd = new SQLiteCommand("SELECT COUNT(*) FROM Courses;", conn);
            long count = (long)countCmd.ExecuteScalar();

            // If there are no courses, insert default data
            if (count == 0)
            {
                // Define course IDs and names
                // (You can customize these course names as needed)
                string[] courseIds = { "C001", "C002", "C003", "C004", "C005" };
                string[] courseNames = {
                "Computer Science",
                "Information Technology",
                "Software Engineering",
                "Computer Engineering",
                "Data Science"
            };

                // Loop through each course and insert it into the Courses table
                for (int i = 0; i < courseIds.Length; i++)
                {
                    var insertCourseCmd = new SQLiteCommand(
                        "INSERT INTO Courses (CourseID, CourseName) VALUES (@id, @name);", conn);
                    insertCourseCmd.Parameters.AddWithValue("@id", courseIds[i]);
                    insertCourseCmd.Parameters.AddWithValue("@name", courseNames[i]);
                    insertCourseCmd.ExecuteNonQuery();
                }

                // Define subjects linked to the courses above
                // Each subject has an ID, name, and associated course ID
                var subjects = new (string SubjectID, string SubjectName, string CourseID)[]
                {
                ("S001", "Data Structures", "C001"),
                ("S002", "Algorithms", "C001"),
                ("S003", "Operating Systems", "C001"),
                ("S004", "Web Development", "C002"),
                ("S005", "Cybersecurity", "C002"),
                ("S006", "Software Testing", "C003"),
                ("S007", "Object-Oriented Programming", "C003"),
                ("S008", "Digital Logic Design", "C004"),
                ("S009", "Microprocessors", "C004"),
                ("S010", "Machine Learning", "C005"),
                ("S011", "Big Data Analytics", "C005")
                };

                // Loop through each subject and insert it into the Subjects table
                foreach (var (subjectId, subjectName, courseId) in subjects)
                {
                    var insertSubjectCmd = new SQLiteCommand(
                        "INSERT INTO Subjects (SubjectID, SubjectName, CourseID) VALUES (@sid, @sname, @cid);", conn);
                    insertSubjectCmd.Parameters.AddWithValue("@sid", subjectId);
                    insertSubjectCmd.Parameters.AddWithValue("@sname", subjectName);
                    insertSubjectCmd.Parameters.AddWithValue("@cid", courseId);
                    insertSubjectCmd.ExecuteNonQuery();
                }
            }
            // If courses already exist, this method does nothing to avoid duplicates
        }
    }*/

}
