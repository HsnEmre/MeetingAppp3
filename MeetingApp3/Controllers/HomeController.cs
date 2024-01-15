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
                

                ViewBag.selamlama=saat>12?"iyi günler":"Günaydın";
                ViewBag.UserName="Hasan Emre";

                //viewbag alternatif
                ViewData["Selamlama"]=saat>12?"iyi günler":"Günaydın";
                ViewData["UserName"]="Hasan Emre Buzkan";

                MeetingInfo meetingInfo=new MeetingInfo(){
                    Id=1,
                    Location="İzmir",
                    Date=new DateTime(2024, 01 ,20 ,0 , 0),
                    NumberOfPeople=100

                };

            return View(meetingInfo);
        }

    }

}