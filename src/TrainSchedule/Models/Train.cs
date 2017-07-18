using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrainSchedule.Models
{
    public class Train
    {
        [Key]
        public Int32 Id { get; set; }

        [Required]
        [MaxLength(25), MinLength(2)]
        public String Title { get; set; }

        [Required]
        public Int32 RailwayCarriageCount { get; set; }
    }
}
