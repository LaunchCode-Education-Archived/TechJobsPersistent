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
        private readonly JobDbContext context;

        public EmployerController(JobDbContext dbcontext)
        {
            context = dbcontext;
        }

        // GET: /Employer
        public IActionResult Index()
        {
            List<Employer> employers = context.Employers.ToList();
            return View(employers);
        }

        // GET: /Employer/Add

        [HttpGet]
        public IActionResult Add()
        {
            AddEmployerViewModel viewModel = new AddEmployerViewModel();
            return View(viewModel);
        }

        // POST: /Employer/ProcessAddEmplyerForm
        [HttpPost]
        public IActionResult ProcessAddEmployerForm(AddEmployerViewModel addEmployerViewModel)
        {
            if (ModelState.IsValid)
            {
                Employer newEmployer = new Employer
                {
                    Name = addEmployerViewModel.Name,
                    Location = addEmployerViewModel.Location
                };

                context.Employers.Add(newEmployer);
                
                context.SaveChanges();
                
                return Redirect("/Employer");
            }

            return View(addEmployerViewModel);
        }

        // GET: /Employer/About/{id}
        public IActionResult About(int id)
        {
            Employer detail = context.Employers.Find(id);
            return View(detail);
        }
    }
}