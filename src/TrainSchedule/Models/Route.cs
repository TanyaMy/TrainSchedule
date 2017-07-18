using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrainSchedule.Models
{
    public class Route
    {
        [Key]
        public Int32 Id { get; set; }

        [ForeignKey("Train")]
        public Int32 TrainId { get; set; }

        public Int32 StartLocationId { get; set; }

        public Int32 FinishLocationId { get; set; }

        [Required]
        [Range(typeof(DateTime), "1/1/2017", "1/1/2020",
        ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public DateTime DepartureTime { get; set; }

        [Required]
        [Range(typeof(DateTime), "1/1/2017", "1/1/2020",
        ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public DateTime ArrivalTime { get; set; }

        public Train Train { get; set; }

        public Location StartLocation { get; set; }

        public Location FinishLocation { get; set; }
    }
}
