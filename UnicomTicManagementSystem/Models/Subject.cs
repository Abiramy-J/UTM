using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicManagementSystem.Models
{
    public class Subject
    {
        public string SubjectID { get; set; } = string.Empty;   
        public string SubjectName { get; set; } = string.Empty;
        public string CourseID { get; set; } = string.Empty;// Foreign key to Course
        public string CourseName { get; set; } = string.Empty; // For UI display, not stored in DB
    }
}
