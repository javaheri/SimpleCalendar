using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleCalendar.ViewModels
{
    public class AppointmentViewModel
    {
        public int Id { get; set; }
        public int CalendarId { get; set; }
        public string Organizer { get; set; }
        public string Subject { get; set; }
        public List<AttendeViewModel> Attendees { get; set; }
        public DateTime Date { get; set; }

        public List<AppointmentViewModel> Appointments { get; set; }
        public string Description { get; internal set; }

        public bool Selected { get; set; }
    }

}