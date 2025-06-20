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
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string SubjectID { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
    
        public string subjects { get; set; } = string.Empty;
        public int UserID { get; set; } // Foreign key to Users table
    }
}