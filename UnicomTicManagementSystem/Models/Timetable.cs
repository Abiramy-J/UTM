using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicManagementSystem.Models
{
    public class Timetable
    {
        public int TimetableID { get; set; }
        public string SubjectID { get; set; } = string.Empty;
        public int RoomID { get; set; }
        public DateTime Date { get; set; }
        public string TimeSlot { get; set; } = string.Empty;

        // For View Only
        public string SubjectName { get; set; } = string.Empty;
        public string RoomName { get; set; } = string.Empty;
    }
}

