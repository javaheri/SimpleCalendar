using SimpleCalendar.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleCalendar.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: Appointment
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Selected(int id)
        {
            var repository = new Repository();
            var appointment = repository.GetAppointmentById(id);
            var appointments = repository.GetAppointmentsByCalendarId(appointment.CalendarId);
            var viewModel = new AppointmentViewModel()
            {
                Id = appointment.Id,
                CalendarId = appointment.CalendarId,
                Date = appointment.Date,
                Organizer = appointment.Organizer,
                Subject = appointment.Subject,
                Description = appointment.Description,
                Attendees = new List<AttendeViewModel>(),
                Appointments = new List<AppointmentViewModel>()
            };

            foreach (var attendee in appointment.Attendees)
            {
                viewModel.Attendees.Add(new AttendeViewModel()
                {
                    Id = attendee.Id,
                    FullName = attendee.FullName,
                });
            }

            foreach (var app in appointments)
            {
                viewModel.Appointments.Add(new AppointmentViewModel()
                {
                    Id = app.Id,
                    Organizer = app.Organizer,
                    Date = app.Date,
                    Subject = app.Subject,
                    Description = app.Description,
                    Selected = app.Id == appointment.Id
                });
            }

            return View(viewModel);

        }
    }
}