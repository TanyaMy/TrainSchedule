using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrainSchedule.Models
{
    public class Location
    {
        [Key]
        public Int32 Id { get; set; }

        [Required]
        [MaxLength(25), MinLength(2)]
        public String Name { get; set; }

        [Required]
        [MaxLength(25), MinLength(2)]
        public String Country { get; set; }
    }
}
