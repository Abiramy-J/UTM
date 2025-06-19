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
        public static string Role { get; set; }        
        public static int StudentID { get; set; }       // only for students (optional)
    }
}
