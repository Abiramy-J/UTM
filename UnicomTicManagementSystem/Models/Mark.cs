using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicManagementSystem.Models
{
    public class Mark
    {
        public int MarkID { get; set; }
        public int StudentID { get; set; }
        public int ExamID { get; set; }
        public int Score { get; set; } // between 0 and 100

        //  for display purposes
        public string StudentName { get; set; } = string.Empty;
        public string ExamName { get; set; } = string.Empty;
        public string SubjectID { get; set; } = string.Empty;
        public string SubjectName { get; set; } = string.Empty;  // Optional: for display

    }
}

