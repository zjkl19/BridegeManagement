using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BridegeManagement.Models;
using AutoMapper;
using BridegeManagement.IRepository;

namespace BridegeManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBridgeRepository _bridgeRepository;
        private readonly IComponentRepository _componentRepository;
        private readonly IDamageRepository _damageRepository;
        private readonly IMapper _mapper;

        public HomeController(
            IMapper mapper
            , IBridgeRepository bridgeRepository
            , IComponentRepository componentRepository
            , IDamageRepository damageRepository)
        {
            _mapper = mapper;
            _bridgeRepository = bridgeRepository;
            _componentRepository = componentRepository;
            _damageRepository = damageRepository;
        }

        [TempData]
        public string StatusMessage { get; set; }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
