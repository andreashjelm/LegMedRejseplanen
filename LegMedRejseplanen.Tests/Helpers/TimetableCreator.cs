using LegMedRejseplanen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegMedRejseplanen.Tests.Helpers
{
    class TimetableCreator
    {
        public Timetable CreateTimetable()
        {
            Timetable timetable = new Timetable();
            timetable.Trips = createTrips(2, 3);
            return timetable;
        }

        private List<Trip> createTrips(int numberOfTripsToCreate, int stopOrPassesPerTrip)
        {
            List<Trip> createdTrips = new List<Trip>();
            for (int i = 0; i < numberOfTripsToCreate; i++)
            {
                Trip createdTrip = new Trip();
                createdTrip.NominalTrainName = "1000" + numberOfTripsToCreate;
                createdTrip.StartDateAndTime = DateTime.Now;
                createdTrip.StopOrPasses = createStopOrPasses(stopOrPassesPerTrip);
                createdTrips.Add(createdTrip);
            }

            return createdTrips;
        }

        private List<StopOrPass> createStopOrPasses(int stopOrPassesPerTrip)
        {
            List<StopOrPass> createdStopOrPasses = new List<StopOrPass>();
            for (int i = 0; i < stopOrPassesPerTrip; i++)
            {
                StopOrPass createdStopOrPass = new StopOrPass();
                createdStopOrPass.StationName = "station_" + i;
                createdStopOrPass.PlannedArrivalTime = DateTime.Now.AddHours(1);
                createdStopOrPass.PlannedDepartureTime = DateTime.Now.AddHours(2);
                createdStopOrPasses.Add(createdStopOrPass);
            }

            return createdStopOrPasses;
    }
}
}
