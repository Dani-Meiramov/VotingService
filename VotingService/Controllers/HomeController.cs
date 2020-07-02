using Microsoft.AspNetCore.Mvc;

namespace VotingService.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}