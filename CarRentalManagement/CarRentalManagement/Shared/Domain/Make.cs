using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Domain
{
    public class Make : BaseDomainModel
    {
        [Required(ErrorMessage = "Please enter a make name.")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Colour name must contain at least 2 characters.")]
        public string Name { get; set; }
    }
}
