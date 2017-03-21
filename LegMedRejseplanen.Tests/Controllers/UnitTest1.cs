using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LegMedRejseplanen.Models;
using System.Collections.Generic;
using LegMedRejseplanen.Tests.Helpers;
using LegMedRejseplanen.Helpers;

namespace LegMedRejseplanen.Tests.Controllers
{
    [TestClass]
    public class TestDataCreator
    {
        
        [TestMethod]
        public void CreateAndPersistTimeTable()
        {
            TimetableCreator creator = new TimetableCreator();
            Timetable timetable = creator.CreateTimetable();
            DbHelper db = new DbHelper();
            bool result = db.putTimetable(timetable.Id, timetable);
            Assert.IsTrue(result, "no Timetable was saved");
            ReadPersistedTimetable();
        }


        [TestMethod]
        public void ReadPersistedTimetable()
        {
            DbHelper db = new DbHelper();
            Timetable timetable = db.getTimetable();
            Assert.IsNotNull(timetable);
            Assert.IsNotNull(timetable.Trips, "no trips were saved");
            foreach (Trip trip in timetable.Trips) {
                Assert.IsNotNull(trip.StopOrPasses, "no SoP");
            }
        }

        //[TestMethod]
        public void ClearDatabase()
        {
            DbHelper db = new DbHelper();
            db.clear();
        }
    }
}
