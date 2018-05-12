using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Models.AccountViewModels;
using App.Models.VisiterPatientViewModels;
using Data;
using Data.MySqlRepositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace App.Controllers
{
    public class VisiterController : Controller
    {

        private readonly ILogger _logger;
        private readonly IPatientUserRepository _patientUserRepository;
        private readonly IPhysicianRepository _physicianRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;


        public VisiterController(
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
        public IActionResult VisiterDashboard()
        {

            var physicianUserDetail = _physicianRepository.GetAll();
            List<PhysicianViewModel> physicianList = new List<PhysicianViewModel>();
            PhysicianViewModel physicianUser;
            foreach (var physician in physicianUserDetail)
            {
                physicianUser = new PhysicianViewModel { Name = physician.Name, Qualification = physician.Qualification, Specialist = physician.Specialist, RegistrationNo = physician.RegistrationNo, Experience = physician.Experience, City = physician.City, CNIC = physician.CNIC, Country = physician.Country, Email = physician.Email, Phone = physician.Phone };
                physicianList.Add(physicianUser);
            }

            ViewData["Message"] = "Your Physician Here's.";
            return View(physicianList);

        }
        public IActionResult AddPatientDisease()
        {
            PatientDisease patientDisease = new PatientDisease();
            patientDisease.Diagnose = new Diagnose { Bloodtest =" pass" };
            patientDisease.DiseasePrevalence = new DiseasePrevalence();
            return View(patientDisease);
        }
        public IActionResult lastVistDate()
        {
            return View();
        }
        public IActionResult currentPatientDiseases()
        {
            return RedirectToAction(nameof(PatientDiseaseController.Index), "PatientDisease");
            //return View();
        }
        public IActionResult visiterTreatmentHistory()
        {
            return View();
        }
        public IActionResult FindPhysician()
        {
            return View();
        }
        public IActionResult BodyMassIndex()
        {
            return View();
        }
        public IActionResult BloodPressureLevel()
        {
            return View();
        }
        public IActionResult SugerLevel()
        {
            return View();
        }
        public IActionResult ColesterolLevel()
        {
            return View();
        }
        public IActionResult DietPlan()
        {
            return View();
        }
        public IActionResult HealthPrecaution()
        {
            return View();
        }

    }
}