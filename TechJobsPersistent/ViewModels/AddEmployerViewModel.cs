using System;
using System.ComponentModel.DataAnnotations;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required (ErrorMessage = "Must Enter Name!")]
        public string Name { get; set; }

        [Required (ErrorMessage = "Must Enter Location!")]
        public string Location { get; set; }


        public AddEmployerViewModel()
        {
        }

        public AddEmployerViewModel(Employer employer)
        {
            Name = employer.Name;
            Location = employer.Location;
        }
    }
}
