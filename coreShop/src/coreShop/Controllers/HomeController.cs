using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coreShop.Services;
using Microsoft.AspNetCore.Mvc;

namespace coreShop.Controllers
{
    public class HomeController : Controller
    {
        readonly IStoreRepository _storeRepository;

        public HomeController(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(_storeRepository.Tweets);
        }
    }
}
