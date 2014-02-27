using HealthyUDailyMiniChallenge.Domain.Concrete;
using HealthyUDailyMiniChallenge.Domain.Entities;
using HealthyUDailyMiniChallenge.Domain.Interfaces;
using HeathyUDailyMiniChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HeathyUDailyMiniChallenge.Controllers
{
    public class ChallengeController : ApiController
    {

        private ChallengeRepository repository = new ChallengeRepository();
        //private IChallengeRepository _challengeRepository;
        //public ChallengeApiController(IChallengeRepository challengeRepository)
        //{
        //    _challengeRepository = challengeRepository;
        //}

        //public challengeuser get()
        //{
        //    challengeuser challengeuser = new challengeuser { availablechallenges = _challengerepository.challenges() };
        //    return challengeuser;
        //}

        public IEnumerable<Challenge> GetAllChallenges()
        {
            return repository.Challenges();
        }
        //public HttpResponseMessage Post(Challenge challenge)
        //{
        //    _challengeRepository.Challenges.Add(challenge);
        //    return Request.CreateResponse(HttpStatusCode.Created, challenge);
        //}
        //public HttpResponseMessage Put(int id, Challenge challenge)
        //{
        //    _challengeRepository.Update(challenge); // make sure it still exists. 
        //    return Request.CreateResponse(HttpStatusCode.Accepted);
        //}


    }
}
