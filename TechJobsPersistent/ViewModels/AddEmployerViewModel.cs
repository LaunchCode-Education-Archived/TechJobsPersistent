using System.ComponentModel.DataAnnotations;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 20 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Location is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Location name must be between 3 and 20 characters")]
        public string Location { get; set; }
    }
}
