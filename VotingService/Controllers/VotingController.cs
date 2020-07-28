using Microsoft.AspNetCore.Mvc;
using VotingService.Models;
using VotingService.Services;

namespace VotingService.Controllers
{
    public class VotingController : Controller
    {
        private readonly IVotingStorageService _votingStorageService;

        public VotingController(IVotingStorageService votingStorageService)
        {
            _votingStorageService = votingStorageService;
        }

        public IActionResult Index()
        {
            return View(_votingStorageService.GetVotingsList());
        }

        public IActionResult CreateVoting()
        {
            return View(new VotingViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateVoting(VotingViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var id = _votingStorageService.RegisterVoting(model);

            return RedirectToAction("Details", new { id = id });
        }

        public IActionResult AddOption(int id)
        {
            return View(new VotingOptionViewModel {VotingId = id});
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOption(VotingOptionViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            _votingStorageService.AddOption(model);

            return RedirectToAction("Details", new { id = model.VotingId });
        }

        public IActionResult Details(int id)
        {
            return View(_votingStorageService.GetVoting(id));
        }

        public IActionResult ShowVotingResult(int id, int selectedOption)
        {
            _votingStorageService.GetVoting(id).Options[selectedOption].VoteCount++;

            return View(_votingStorageService.GetVoting(id));
        }
    }
}