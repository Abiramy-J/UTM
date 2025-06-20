using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicManagementSystem.Models
{
    public class Exam
    {
        public int ExamID { get; set; }
        public string SubjectID { get; set; }= string.Empty; // Foreign key to Subject table
        public string ExamName { get; set; } = string.Empty;
        public DateTime ExamDate { get; set; }
    }
}
