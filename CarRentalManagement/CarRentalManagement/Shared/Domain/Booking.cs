using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Domain
{
    public class Booking : BaseDomainModel, IValidatableObject
    {
        [Required]
        [Range(1, 2147483647,  ErrorMessage = "Please select a vehicle.")]
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }

        [Required(ErrorMessage = "Please select a date out.")]
        public DateTime DateOut { get; set; }
        public DateTime? DateIn { get; set; }

        [Required]
        [Range(1, 2147483647, ErrorMessage = "Please select a customer.")]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (DateIn != null)
            {
                if (DateIn <= DateOut)
                {
                    yield return new ValidationResult("Date In must be greater than Date Out", new[] { "DateIn" });
                }
            }
        }
    }
}