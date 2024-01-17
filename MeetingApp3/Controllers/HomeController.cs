using MeetingApp3.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp3.Controllers
{
    public class HomeController:Controller
    {
        //Localhost / Home
        public IActionResult Index()
        {
                int saat= DateTime.Now.Hour;
                
                ViewData["Selamlama"]=saat>12?"iyi günler":"Günaydın";
                int userCount=Repository.Users.Where(info=>info.WillAttend==true).Count();

                var meetingInfo=new MeetingInfo(){
                    Id=1,
                    Location="İstanbul",
                    Date=new DateTime(2023,01,20,20,0,0),
                    NumberOfPeople=userCount
                };
                

            return View();
        }

    }

}