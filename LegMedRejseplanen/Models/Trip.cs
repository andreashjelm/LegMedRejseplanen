using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LegMedRejseplanen.Models
{
    public class Trip
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public String NominalTrainName { get; set; }
        public DateTime StartDateAndTime { get; set; }
        public List<StopOrPass> StopOrPasses { get; set; }
    }
}