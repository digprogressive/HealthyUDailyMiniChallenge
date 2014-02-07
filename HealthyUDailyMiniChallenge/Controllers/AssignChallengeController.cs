using HealthyUDailyMiniChallenge.Domain.Interfaces;
using HeathyUDailyMiniChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HeathyUDailyMiniChallenge.Controllers
{
    public class AssignChallengeController : Controller
    {
        private IChallengeRepository _challengeRepository;
        public AssignChallengeController(IChallengeRepository challengeRepository)
        {
            _challengeRepository = challengeRepository;
        }

        //
        // GET: /AssignChallenge/

        public ActionResult Index()
        {
            ChallengeUser challengeUser = new ChallengeUser { AvailableChallenges = _challengeRepository.Challenges() };
            return View(challengeUser);
        }

    }
}
