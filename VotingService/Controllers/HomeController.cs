using VotingService.Models;
using Microsoft.AspNetCore.Mvc;

namespace VotingService.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Index(int option, VotingViewModel model)
        //{
        //    model.Options[option].VoteCount++;
        //    return View("Result", model);
        //}
    }
}