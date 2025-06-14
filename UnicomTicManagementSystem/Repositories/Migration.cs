﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                ExamName TEXT NOT NULL,
                SubjectID TEXT,
                FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID)
            );",

            // 6. Marks Table
            @"CREATE TABLE IF NOT EXISTS Marks (
                MarkID INTEGER PRIMARY KEY AUTOINCREMENT,
                StudentID TEXT,
                ExamID INTEGER,
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
                SubjectID TEXT,
                TimeSlot TEXT NOT NULL,
                RoomID INTEGER,
                FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID),
                FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID)
            );"
        };

            foreach (var sql in tableCommands)
            {
                using var command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();
            }
        }
    }

}

