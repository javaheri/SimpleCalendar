using SimpleCalendar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleCalendar.ViewModels
{
    public class CalendarViewModel
    {
        public CalendarViewModel()
        {
            Appointments = new List<AppointmentViewModel>();
        }
        public int Id { get; set; }
        public IList<AppointmentViewModel> Appointments { get; set; }
    }
}