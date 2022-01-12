using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechJobsPersistent.Data;
using TechJobsPersistent.Models;
using TechJobsPersistent.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsPersistent.Controllers
{
    public class EmployerController : Controller
    {
        // GET: /<controller>/
        private JobDbContext context;

        public EmployerController(JobDbContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()
        {
            List<Employer> employers = context.Employers.ToList();
            return View(employers);
        }

        public IActionResult Add()
        {
            AddEmployerViewModel addEmployerViewModel = new AddEmployerViewModel();
            return View(addEmployerViewModel);
        }
        [HttpPost]
        public IActionResult Add(AddEmployerViewModel employer)
        {
            if (ModelState.IsValid)
            {
                Employer newEmployer = new Employer
                {
                    Name = employer.Name,
                    Location = employer.Location
                };
                context.Employers.Add(newEmployer);
                context.SaveChanges();
                return Redirect("Index");
            }
            else return View(employer);
        }

        public IActionResult About(int id)
        {
            List<Employer> employers = context.Employers.ToList();
            Employer theEmployer;
            foreach(Employer employer in employers)
            {
                if (employer.Id == id)
                {
                    theEmployer = employer;
                    return View(theEmployer);
                }
            }
            return View();
            
        }
    }
}
