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
        public string SubjectID { get; set; }
        public string ExamName { get; set; }
        public DateTime ExamDate { get; set; }
    }
}
