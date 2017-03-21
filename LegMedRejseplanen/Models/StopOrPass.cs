using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LegMedRejseplanen.Models
{
    public class StopOrPass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public String StationName { get; set; }
        public DateTime PlannedArrivalTime { get; set; }
        public DateTime PlannedDepartureTime { get; set; }

    }
}