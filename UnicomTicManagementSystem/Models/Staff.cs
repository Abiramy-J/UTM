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
        public string Name { get; set; }
        public int UserID { get; set; } // Foreign key from Users table


    }
}
