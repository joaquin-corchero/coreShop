using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coreShop.Services;
using Microsoft.AspNetCore.Mvc;

namespace coreShop.Controllers
{
    public class TweetController : Controller
    {
        readonly ITweetRepository _tweetRepository;

        public TweetController(ITweetRepository tweetRepository)
        {
            _tweetRepository = tweetRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(_tweetRepository.Tweets);
        }
    }
}
