using Microsoft.AspNetCore.Mvc;

namespace MVCDemo.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult PersonalDetails()
        {
            return View();
        }
    }
}
