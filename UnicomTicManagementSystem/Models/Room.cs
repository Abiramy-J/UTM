using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicManagementSystem.Models
{
    public class Room
    {
        public int RoomID { get; set; }
        public string RoomType { get; set; } = string.Empty;    
        public string RoomName { get; set; } = string.Empty;
    }
}
