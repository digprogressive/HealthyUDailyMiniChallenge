using HealthyUDailyMiniChallenge.Domain.Concrete;
using HealthyUDailyMiniChallenge.Domain.Interfaces;
using HeathyUDailyMiniChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace HeathyUDailyMiniChallenge.Controllers
{
    public class AssignChallengeServiceController : ApiController
    {
        private ChallengeRepository repository = new ChallengeRepository();
        //private IChallengeRepository _challengeRepository;
        //public AssignChallengeController(IChallengeRepository challengeRepository)
        //{
        //    _challengeRepository = challengeRepository;
        //}

        public HttpResponseMessage Post(ChallengeUser challengeuser)
        {
            
            //add to entity framework
            return Request.CreateResponse(HttpStatusCode.Created, challengeuser);
        }
        //
        // GET: /AssignChallenge/

    }
}
