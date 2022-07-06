using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Chat.Models;
using Microsoft.AspNetCore.Authorization;

namespace Chat.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        [Authorize]
        public IActionResult Index()
        {
            var sa = User.Claims;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}