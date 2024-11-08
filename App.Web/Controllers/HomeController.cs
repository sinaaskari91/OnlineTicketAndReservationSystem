using DataTransferObject.DTOClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineTicketAndReservationSystem.Models;
using Service.ServiceInterfaces;
using SQLitePCL;
using System.Diagnostics;

namespace OnlineTicketAndReservationSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserService _userservice;
        private readonly IProvinceService _provinceService;

        public HomeController(ILogger<HomeController> logger , IUserService userservice ,IProvinceService provinceService)
        {
            _logger = logger;
            _userservice =userservice;
            _provinceService = provinceService;
        }
        [Authorize]
        public async Task<IActionResult> index()  
        {
            var users = await _userservice.GetAllUsers();
            return View(users);
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

        [Authorize]
        public IActionResult Province()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreateProvince([FromBody] ProvinceDTO provinceDTO)
        {
            if(ModelState.IsValid)
            {
                var result=await _provinceService.CreateProvince(provinceDTO);
                return Json(result);
            }
            return View();
        }
    }
}


