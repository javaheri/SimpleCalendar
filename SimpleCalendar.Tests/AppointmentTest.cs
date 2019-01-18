using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalendar.Tests
{
    [TestClass]
    public class AppointmentTest
    {
        [TestMethod]
        public void FirstAppointmentAttendeeCountTest()
        {
            var repository = new Repository();

            var firstAppointment = repository.GetAppointments().FirstOrDefault();

            Assert.AreEqual(2, firstAppointment.Attendees.Count);
        }
    }
}
