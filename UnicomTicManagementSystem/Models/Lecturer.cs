using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicManagementSystem.Models
{
    public class Lecturer
    {
        public int LecturerID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string SubjectID { get; set; }
        public string Username { get; set; }
    
        public string subjects { get; set; }
        public int UserID { get; set; } // Foreign key to Users table
    }
}