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
        public string SubjectID { get; set; }
        public int RoomID { get; set; }
        public DateTime Date { get; set; }
        public string TimeSlot { get; set; }

        // For View Only
        public string SubjectName { get; set; }
        public string RoomName { get; set; }
    }
}

