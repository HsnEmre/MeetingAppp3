using Microsoft.AspNetCore.Mvc;

namespace MeetingApp3.Controllers
{
    public class HomeController:Controller
    {
        //Localhost / Home
        public IActionResult Index(){
            return View();
        }

    }

}