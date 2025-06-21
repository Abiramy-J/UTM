using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicManagementSystem.Models
{
    public class Staff
    {
        public int StaffID { get; set; }
        public int UserID { get; set; }  // FK from Users table
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string username { get; set; } = string.Empty;// Username for login,for view only
        public string password { get; set; }// Password for login,for view only

    }
}
