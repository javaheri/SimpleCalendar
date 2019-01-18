using SimpleCalendar.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleCalendar.Controllers
{
    public class CalendarController : Controller
    {
        // GET: Calendar
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SelectedMonth(int id)
        {
            var repository = new Repository();
            var viewModel = new CalendarViewModel();
            var calendar = repository.GetCalendarById(id);
            var appointments = repository.GetAppointmentsByCalendarId(id);
            viewModel.Id = calendar.Id;
            foreach (var appointment in appointments)
            {
                viewModel.Appointments.Add(new AppointmentViewModel()
                {
                    Id = appointment.Id,
                    CalendarId = appointment.CalendarId,
                    Organizer = appointment.Organizer,
                    Date = appointment.Date,
                    Subject = appointment.Subject
                });
            }
            return View(viewModel);
        }
    }
}