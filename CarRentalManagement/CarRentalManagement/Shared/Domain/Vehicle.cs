using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Domain
{
    public class Vehicle : BaseDomainModel
    {
        [Required(ErrorMessage = "Please enter model year.")]
        [Range(2000, 2100, ErrorMessage = "Please enter a year between 2000 and 2100.")]
        public int Year { get; set; }

        [Required]
        [Range(1, 2147483647, ErrorMessage = "Please select a model.")]
        public int ModelId { get; set; }
        public virtual Model Model { get; set; }

        [Required]
        [Range(1, 2147483647, ErrorMessage = "Please select a make.")]
        public int MakeId { get; set; }
        public virtual Make Make { get; set; }

        [Required]
        [Range(1, 2147483647, ErrorMessage = "Please select a colour.")]
        public int ColourId { get; set; }
        public virtual Colour Colour { get; set; }

        [Required(ErrorMessage = "Please enter a vehicle identification number.")]
        [StringLength(16, MinimumLength = 8, ErrorMessage = "VIN must contain at least 8 alpha-numeric characters.")]
        public string Vin { get; set; }

        [Required(ErrorMessage = "Please enter license plate number.")]
        [StringLength(16, MinimumLength = 6, ErrorMessage = "License plate number must contain at least 6 alpha-numeric characters.")]
        public string LicensePlateNumber { get; set; }

        [Required]
        public double RentalRate { get; set; }

        public virtual List<Booking> Bookings { get; set; }
    }
}
