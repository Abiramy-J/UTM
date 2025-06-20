using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicManagementSystem.Models
{
    public class User
    {
        public int UserId { get; set; }//PK
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;//Admin, Student, Staff, Lecturer
    }
    public class ComboBoxItem
    {
        public string Text { get; set; }   // Displayed text (e.g., CourseName)
        public string Value { get; set; }  // Internal value (e.g., CourseID like "C1001")

        public ComboBoxItem(string text, string value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text; // So ComboBox displays only course name
        }
    }



}
