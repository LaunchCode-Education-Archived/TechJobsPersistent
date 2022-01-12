using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 20 characters")]
        public string JobName { get; set; }
        public int EmployerId { get; set; }
        public List<SelectListItem> Employers { get; set; }
        public List<Skill> Skills { get; set; }
        public AddJobViewModel(List<Employer> employers, List<Skill> skills)
        {
            Employers = new List<SelectListItem>();

            foreach(var employer in employers)
            {
                Employers.Add(
                    new SelectListItem
                    {
                        Value = employer.Id.ToString(),
                        Text = employer.Name,
                    });
            }

            Skills = skills;

            /*foreach(var skill in skills)
            {
                Skills.Add(skill);
                *//*Skills.Add(
                    new SelectListItem
                    {
                        Value = skill.Id.ToString(),
                        Text = skill.Name
                    });*//*
            }*/
        }

        public AddJobViewModel() { }
        

    }
}
