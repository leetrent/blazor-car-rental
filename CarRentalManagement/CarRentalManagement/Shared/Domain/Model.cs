using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Domain
{
    public class Model : BaseDomainModel
    {
        [Required(ErrorMessage = "Please enter a model name.")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Colour name must contain at least 2 characters.")]
        public string Name { get; set; }
    }
}
