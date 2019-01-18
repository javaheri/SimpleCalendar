using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleCalendar.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public int CalendarId { get; set; }
        public string Organizer { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public List<Attende> Attendees { get; set; }
        public DateTime Date { get; set; }
    }
}