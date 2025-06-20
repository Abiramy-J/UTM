using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicManagementSystem.Models
{
    public static class AppSession
    {
        public static int UserId { get; set; }  // user table ID
        public static string Role { get; set; } = string.Empty; // "admin", "lecturer", "student", etc.
        public static int StudentID { get; set; }       // only for students (optional)
    
    public static void Clear()
        {
            UserId = 0;
            StudentID = 0;
            Role = string.Empty;
        }

    }
}