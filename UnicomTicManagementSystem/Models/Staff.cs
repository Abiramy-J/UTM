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
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string username { get; set; } // Username for login,for view only

    }
}
