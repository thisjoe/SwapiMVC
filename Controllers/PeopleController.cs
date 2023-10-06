using Microsoft.AspNetCore.Mvc;

namespace SwapiMVC.Controllers
{
    public class PeopleController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}