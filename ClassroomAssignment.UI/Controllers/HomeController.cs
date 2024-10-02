using ClassroomAssignment.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ClassroomAssignment.Domain.Models;
using ClassroomAssignment.DomainServices;

namespace ClassroomAssignment.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudentClassRepo _studentClassRepo;
        public HomeController(ILogger<HomeController> logger, IStudentClassRepo studentClassRepo)
        {
            _logger = logger;
            _studentClassRepo = studentClassRepo;
        }

        public IActionResult Index()
        {
            var studentClasses = _studentClassRepo.GetAll() ?? new List<StudentClass>();
            return View(studentClasses.ToList());
        }
        
        public IActionResult Details(Guid id)
        {
            var studentClass = _studentClassRepo.GetById(id);

            return View(studentClass);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
