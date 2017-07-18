using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrainSchedule.Models
{
    public class Ticket
    {
        [Key]
        public Int32 Id { get; set; }

        [ForeignKey("Route")]
        public Int32 RouteId { get; set; }

        [Required]
        public Int32 RailwayCarriageNumber { get; set; }

        [Required]
        [Range(0, 100)]
        public Int32 Place { get; set; }       

        [Range(0, 1000000)]
        public Decimal Price { get; set; }

        public String ApplicationUserLogin { get; set; }

        public Route Route { get; set; }
    }
}
