using System;
using System.ComponentModel.DataAnnotations;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        
        [Required(ErrorMessage = "The Employer's Name is required.")]
        
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 charecters in length.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Employer's Location is required.")]
        
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Location must be between 3 and 50 charecters in length.")]
        public string Location { get; set; }

        public AddEmployerViewModel(string name, string location)
        {
            Name = name;
            Location = location;
        }

        public AddEmployerViewModel() 
        { 
        }
    }
}