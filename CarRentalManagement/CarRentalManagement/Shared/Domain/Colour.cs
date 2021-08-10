using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement.Shared.Domain
{
    public class Colour : BaseDomainModel
    {
        [Required(ErrorMessage = "Please enter a colour name.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Colour name must contain at least 3 characters.")]
        public string Name { get; set; }
    }
}