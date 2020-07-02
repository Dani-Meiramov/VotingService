using VotingService.Models;
using Microsoft.AspNetCore.Mvc;

namespace VotingService.Controllers
{
    public class SignInController : Controller
    {
        public IActionResult SignIn()
        {
            return View(new SignInViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SignIn(SignInViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("Index", "Voting");
        }
    }
}