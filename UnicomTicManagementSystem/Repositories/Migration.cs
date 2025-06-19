using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Net;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using UnicomTicManagementSystem.Models;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UnicomTicManagementSystem.Repositories
{
    public static class Migration
    {
        public static void RunMigrations()
        {
            using var connection = DbConfig.GetConnection();
            connection.Open();

            string[] tableCommands =
            {
            // 1. Users Table
            @"CREATE TABLE IF NOT EXISTS Users (
                UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                Username TEXT NOT NULL,
                Password TEXT NOT NULL,
                Role TEXT NOT NULL
            );",

            // 2. Courses Table
            @"CREATE TABLE IF NOT EXISTS Courses (
                CourseID TEXT PRIMARY KEY,
                CourseName TEXT NOT NULL
            );",

            // 3. Subjects Table
            @"CREATE TABLE IF NOT EXISTS Subjects (
                SubjectID TEXT PRIMARY KEY,
                SubjectName TEXT NOT NULL,
                CourseID TEXT,
                FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
            );",

            // 4. Students Table
            @"CREATE TABLE IF NOT EXISTS Students(
                StudentID INTEGER PRIMARY KEY AUTOINCREMENT,
                Name TEXT NOT NULL,
                Address TEXT,
                Email TEXT,
                Phone TEXT,
                DOB TEXT,
                Gender TEXT,
                CourseID TEXT,
                UserID INTEGER,
                FOREIGN KEY(CourseID) REFERENCES Courses(CourseID),
                FOREIGN KEY(UserID) REFERENCES Users(UserID)
             );",

            // 5. Exams Table
            @"CREATE TABLE IF NOT EXISTS Exams (
                ExamID INTEGER PRIMARY KEY AUTOINCREMENT,
                SubjectID TEXT,
                ExamName TEXT NOT NULL,
                ExamDate TEXT NOT NULL,
                FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID)  
            );",

            // 6. Marks Table
            @"CREATE TABLE IF NOT EXISTS Marks (
                MarkID INTEGER PRIMARY KEY AUTOINCREMENT,
                StudentID INTEGER NOT NULL,
                ExamID INTEGER NOT NULL,
                Score INTEGER CHECK(Score >= 0 AND Score <= 100),
                FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
                FOREIGN KEY (ExamID) REFERENCES Exams(ExamID)
            );",

            // 7. Rooms Table
            @"CREATE TABLE IF NOT EXISTS Rooms (
                RoomID INTEGER PRIMARY KEY AUTOINCREMENT,
                RoomName TEXT NOT NULL,
                RoomType TEXT NOT NULL
            );",

            // 8. Timetables Table
            @"CREATE TABLE IF NOT EXISTS Timetables (
                TimetableID INTEGER PRIMARY KEY AUTOINCREMENT,
                SubjectID TEXT NOT NULL,
                Date TEXT NOT NULL,
                TimeSlot TEXT NOT NULL,
                RoomID INTEGER NOT NULL,
                FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID),
                FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID)
            );",
            // 9. Staff Table

             @"CREATE TABLE IF NOT EXISTS Staffs (
                StaffID INTEGER PRIMARY KEY AUTOINCREMENT,
                FullName TEXT NOT NULL,
                Address TEXT NOT NULL,
                Email TEXT NOT NULL,
                Phone TEXT NOT NULL,
                UserID INTEGER NOT NULL, -- Foreign Key to Users

                FOREIGN KEY (UserID) REFERENCES Users(UserID)
            );",


            @"CREATE TABLE IF NOT EXISTS Lecturers (
                LecturerID INTEGER PRIMARY KEY AUTOINCREMENT,
                Name TEXT NOT NULL,
                Address TEXT,
                Email TEXT,
                Phone TEXT,
                SubjectID INTEGER, -- Foreign Key
                UserID INTEGER,
                FOREIGN KEY (UserID) REFERENCES Users(UserID),
                FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID)
            );",

               /*         @"CREATE TABLE LecturerSubjects (
                LecturerID INTEGER,
                SubjectID INTEGER,
                PRIMARY KEY (LecturerID, SubjectID),
                FOREIGN KEY (LecturerID) REFERENCES Lecturers(LecturerID),
                FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID)
            );",*/

        };


            foreach (var sql in tableCommands)
            {
                using var command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();
            }
        }
    }

}

