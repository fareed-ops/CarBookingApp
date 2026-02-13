using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CarBookingAppData
{

    public class Make
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; } = null!;

        public virtual List<Car> Cars { get; set; } = new List<Car>();
    }
}
