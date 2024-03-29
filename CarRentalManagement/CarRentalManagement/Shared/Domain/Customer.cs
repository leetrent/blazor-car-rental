﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter Tax Id")]
        [StringLength(15, MinimumLength = 8)]
        public string TaxId { get; set; }
        public string Address { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string ContactNumber { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailAddress { get; set; }
       public virtual List<Booking> Bookings { get; set; }
    }
}