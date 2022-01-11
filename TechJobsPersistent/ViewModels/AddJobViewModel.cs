using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        public string Name { get; set; }
        public int EmployerId { get; set; }
        public List<SelectListItem> Employers { get; set; }
        public List<Skill> Skills { get; set; }

        public AddJobViewModel()
        {
        }

        public AddJobViewModel(List<Employer> employers, List<Skill> skills)
        {
            Employers = new List<SelectListItem>();
            Skills = skills;

            foreach (Employer employer in employers) //worst loop in the project..
            {
                Employers.Add(
                    new SelectListItem
                    {
                        Value = employer.Id.ToString(),
                        Text = employer.Name
                    }
                );
            }

        }

    }
}
