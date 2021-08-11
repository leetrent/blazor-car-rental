using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Domain
{
    public class Colour : BaseDomainModel
    {
        [Required(ErrorMessage = "Please enter a colour name.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Colour name must contain at least 3 characters.")]
        public string Name { get; set; }
    }
}