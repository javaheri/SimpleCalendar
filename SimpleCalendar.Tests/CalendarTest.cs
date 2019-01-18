using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalendar.Tests
{
    [TestClass]
    public class CalendarTest
    {
        [TestMethod]
        public void CalendarMonthCountTest()
        {
            var repository = new Repository();

            var calendars = repository.GetCalendars();

            Assert.AreEqual(12, calendars.Count);
        }

        [TestMethod]
        public void SecondMonthNameTest()
        {
            var repository = new Repository();

            var secondMonth = repository.GetCalendars()
                                    .Skip(1)
                                    .Take(1)
                                    .First();

            Assert.AreEqual("Feb", secondMonth.Name);
        }
    }
}
