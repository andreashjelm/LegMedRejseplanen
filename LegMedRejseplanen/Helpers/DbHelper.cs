using LegMedRejseplanen.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Http.ModelBinding;

namespace LegMedRejseplanen.Helpers
{
    public class DbHelper
    {

        private Model1 db = new Model1();
        public bool putTimetable(int id, Timetable timetable)
        {
            bool result = false;
            db.Timetables.Add(timetable);
            try
            {
                db.SaveChanges();
                result = true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (TimetableExists(id))
                {
                    result = true;
                }
            }

            return result;
        }

        public Timetable getTimetable()
        {
            Timetable timetable = db.Timetables.First();
            return timetable;
        }

        private bool TimetableExists(int id)
        {
            return db.Timetables.Count(e => e.Id == id) > 0;
        }

        public void clear()
        {
            db.Database.Delete();
        }
    }
}