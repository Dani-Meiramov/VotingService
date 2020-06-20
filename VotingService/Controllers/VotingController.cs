using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VotingService.Models;
using VotingService.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
        public IActionResult CreateVoting(VotingViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var id =

                _votingStorageService.RegisterVoting(new Voting
                {
                    VotingName = model.VotingName,
                    Question = model.Question,
                    Options = model.Options
                });

            return RedirectToAction("Details", new { id = id });
        }

        public IActionResult Details(int id)
        {
            return View(_votingStorageService.GetVoting(id));
        }
    }
}