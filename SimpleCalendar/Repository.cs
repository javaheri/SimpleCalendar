using SimpleCalendar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleCalendar
{
    public class Repository
    {
        public List<Calendar> GetCalendars()
        {
            return new List<Calendar>()
            {
                new Calendar() {
                    Id = 1,
                    Name = "Jan"
                },

                new Calendar() {
                    Id = 2,
                    Name = "Feb"
                },

               new Calendar() {
                    Id = 3,
                    Name = "Mar"
                },
                new Calendar() {
                    Id = 4,
                    Name = "Apr"
                },
                new Calendar() {
                    Id = 5,
                    Name = "May"
                },
                new Calendar() {
                    Id = 6,
                    Name = "Jun"
                },
                new Calendar() {
                    Id = 7,
                    Name = "Jul"
                },
                new Calendar() {
                    Id = 8,
                    Name = "Aug"
                },
                new Calendar() {
                    Id = 9,
                    Name = "Sep"
                },
               new Calendar() {
                    Id = 10,
                    Name = "Oct"
                },
                new Calendar() {
                    Id = 11,
                    Name = "Nov"
                },
               new Calendar() {
                    Id = 12,
                    Name = "Des"
                }
            };
        }

        public List<Appointment> GetAppointments()
        {
            return new List<Appointment>()
            {
                new Appointment() {
                            Id = 1000,
                            CalendarId = 1,
                            Date = DateTime.Now.AddHours(1),
                            Organizer = "Tim Smith",
                            Subject = "Meeting with others",
                            Description = "Description of Metting",
                            Attendees = new List<Attende>() {
                                new Attende() { Id = 100,FullName="Mr. Adam"},
                                new Attende() { Id = 100,FullName="Ms. Alis"}
                            }
                        },
                new Appointment() {
                            Id = 1001,
                            CalendarId = 1,
                            Date = DateTime.Now.AddHours(3),
                            Organizer = "Jon Mack",
                            Subject = "Interview",
                            Description= "Description of Interview",
                            Attendees = new List<Attende>() {
                                new Attende() { Id = 100,FullName="Mr. Brak Bamo"}
                            }
                        },
                 new Appointment() {
                            Id = 2000,
                            CalendarId = 2,
                            Date = DateTime.Now.AddHours(3),
                            Organizer = "Jon Mack",
                            Subject = "Interview",
                            Description = "Another Description",
                            Attendees = new List<Attende>() {
                                new Attende() { Id = 100,FullName="Mr. Brak Bamo"}
                            }
                        },
                  new Appointment() {
                            Id = 2001,
                            CalendarId = 2,
                            Date = DateTime.Now.AddDays(5),
                            Organizer = "H. Jon",
                            Subject = "Holiday Solutions",
                            Description = "Holiday Description",
                            Attendees = new List<Attende>() {
                                new Attende() { Id = 100,FullName="Mr. Woo"},
                                new Attende() { Id = 100,FullName="Ms. Bee"}
                            }
                  },
                  new Appointment() {
                            Id = 3000,
                            CalendarId = 3,
                            Date = DateTime.Now.AddDays(5),
                            Organizer = "H. Jon",
                            Subject = "Holiday Solutions",
                            Attendees = new List<Attende>() {
                                new Attende() { Id = 100,FullName="Mr. Woo"},
                                new Attende() { Id = 100,FullName="Ms. Bee"}
                            }
                        }, new Appointment() {
                            Id = 4000,
                            CalendarId = 4,
                            Date = DateTime.Now.AddHours(1),
                            Organizer = "Hamed",
                            Subject = "Title",
                            Attendees = new List<Attende>() {
                                new Attende() { Id = 100,FullName="Mr. A"},
                                new Attende() { Id = 100,FullName="Ms. B"},
                                new Attende() { Id = 100,FullName="Ms. C"},
                            }
                        },
                         new Appointment() {
                            Id = 5000,
                            CalendarId = 5,
                            Date = DateTime.Now.AddHours(1),
                            Organizer = "Hamed",
                            Subject = "Title",
                            Attendees = new List<Attende>() {
                                new Attende() { Id = 100,FullName="Mr. A"},
                                new Attende() { Id = 100,FullName="Ms. B"},
                                new Attende() { Id = 100,FullName="Ms. C"},
                            }
                        },
                          new Appointment() {
                            Id = 6000,
                            CalendarId = 6,
                            Date = DateTime.Now.AddHours(1),
                            Organizer = "Hamed",
                            Subject = "Title",
                            Attendees = new List<Attende>() {
                                new Attende() { Id = 100,FullName="Mr. A"},
                                new Attende() { Id = 100,FullName="Ms. B"},
                                new Attende() { Id = 100,FullName="Ms. C"},
                            }
                        },
                           new Appointment() {
                            Id = 7000,
                            CalendarId = 7,
                            Date = DateTime.Now.AddHours(1),
                            Organizer = "Hamed",
                            Subject = "Title",
                            Attendees = new List<Attende>() {
                                new Attende() { Id = 100,FullName="Mr. A"},
                                new Attende() { Id = 100,FullName="Ms. B"},
                                new Attende() { Id = 100,FullName="Ms. C"},
                            }
                        },
                            new Appointment() {
                            Id = 8000,
                            CalendarId = 8,
                            Date = DateTime.Now.AddHours(1),
                            Organizer = "Hamed",
                            Subject = "Title",
                            Attendees = new List<Attende>() {
                                new Attende() { Id = 100,FullName="Mr. A"},
                                new Attende() { Id = 100,FullName="Ms. B"},
                                new Attende() { Id = 100,FullName="Ms. C"},
                            }
                        }, new Appointment() {
                            Id = 9000,
                            CalendarId = 9,
                            Date = DateTime.Now.AddHours(1),
                            Organizer = "Hamed",
                            Subject = "Title",
                            Attendees = new List<Attende>() {
                                new Attende() { Id = 100,FullName="Mr. A"},
                                new Attende() { Id = 100,FullName="Ms. B"},
                                new Attende() { Id = 100,FullName="Ms. C"},
                            }
                        },
                             new Appointment() {
                            Id = 10000,
                            CalendarId = 10,
                            Date = DateTime.Now.AddHours(1),
                            Organizer = "Hamed",
                            Subject = "Title",
                            Attendees = new List<Attende>() {
                                new Attende() { Id = 100,FullName="Mr. A"},
                                new Attende() { Id = 100,FullName="Ms. B"},
                                new Attende() { Id = 100,FullName="Ms. C"},
                            }
                        },
                              new Appointment() {
                            Id = 11000,
                            CalendarId = 11,
                            Date = DateTime.Now.AddHours(1),
                            Organizer = "Hamed",
                            Subject = "Title",
                            Attendees = new List<Attende>() {
                                new Attende() { Id = 100,FullName="Mr. A"},
                                new Attende() { Id = 100,FullName="Ms. B"},
                                new Attende() { Id = 100,FullName="Ms. C"},
                            }
                        },
                               new Appointment() {
                            Id = 12000,
                            CalendarId = 12,
                            Date = DateTime.Now.AddHours(1),
                            Organizer = "Hamed",
                            Subject = "Title",
                            Attendees = new List<Attende>() {
                                new Attende() { Id = 100,FullName="Mr. A"},
                                new Attende() { Id = 100,FullName="Ms. B"},
                                new Attende() { Id = 100,FullName="Ms. C"},
                            }
                        }

            };
        }

        public Calendar GetCalendarById(int calendarId)
        {
            var calendar = GetCalendars()
                            .FirstOrDefault(c => c.Id == calendarId);
            return calendar;
        }

        public List<Appointment> GetAppointmentsByCalendarId(int calendarId)
        {
            return GetAppointments()
                             .Where(c => c.CalendarId == calendarId)
                             .ToList();
        }

        public Appointment GetAppointmentById(int appointmentId)
        {
            return GetAppointments()
                            .FirstOrDefault(c => c.Id == appointmentId);
        }


    }
}