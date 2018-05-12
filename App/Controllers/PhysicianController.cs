using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Models.AccountViewModels;
using Data;
using Data.MySqlRepositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace App.Controllers
{
    public class PhysicianController : Controller
    {
        private readonly ILogger _logger;
        private readonly IPatientUserRepository _patientUserRepository;
        private readonly IPhysicianRepository _physicianRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;


        public PhysicianController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<AccountController> logger,
            IPatientUserRepository patientUserRepository,
            IPhysicianRepository physicianRepository)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _physicianRepository = physicianRepository;
            _patientUserRepository = patientUserRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Dashboard()
        {

            var patientUserDetail = _patientUserRepository.GetAll();
            List<PatientUserViewModel> PatientUserList = new List<PatientUserViewModel>();
            PatientUserViewModel patientUser;
            foreach (var visiter in patientUserDetail)
            {
                patientUser = new PatientUserViewModel { Name = visiter.Name, Age = visiter.Age, Gender = visiter.Gender, City = visiter.City, CNIC = visiter.CNIC, Country = visiter.Country, Email = visiter.Email, Phone = visiter.Phone };
                PatientUserList.Add(patientUser);
            }

            ViewData["Message"] = "Your visiter patient here's.";
            return View(PatientUserList);

        }
    }
}