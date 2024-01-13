using Microsoft.AspNetCore.Mvc;

namespace MeetingApp3.Controllers
{
    public class MapController:Controller
    {
        public IActionResult Index()
        {
            return View();
           
        }
        public IActionResult Apply(){
            return View();
        }

         public IActionResult List(){
            return View();
        }
    }
    
}