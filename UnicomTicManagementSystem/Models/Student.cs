using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicManagementSystem.Models
{
    public class Student
    {
        public int StudentID { get; set; }//pk
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string CourseID { get; set; }
        public int UserID { get; set; }
    }
}
