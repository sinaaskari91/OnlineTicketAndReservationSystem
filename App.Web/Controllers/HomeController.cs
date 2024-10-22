using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineTicketAndReservationSystem.Models;
using Service.ServiceInterfaces;
using System.Diagnostics;

namespace OnlineTicketAndReservationSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserService _userservice;

        public HomeController(ILogger<HomeController> logger , IUserService userservice)
        {
            _logger = logger;
            _userservice =userservice;
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
    }
}
