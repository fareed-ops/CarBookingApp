using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace CarBookingAppData
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        [Range(1900, 2025)]
        public int Year { get; set; }

        [Required]
        [StringLength(150, ErrorMessage = "Name is too long !!!")]
        public string Model { get; set; } = null!;

        [Required]
        public int MakeId { get; set; }

        public virtual Make? Make { get; set; }
    }

}
