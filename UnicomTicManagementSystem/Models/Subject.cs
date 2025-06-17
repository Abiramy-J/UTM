using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicManagementSystem.Models
{
    public class Subject
    {
        public string SubjectID { get; set; }
        public string SubjectName { get; set; }
        public string CourseID { get; set; } // Foreign key to Course
        public string CourseName { get; set; } // For UI display, not stored in DB
    }
}
