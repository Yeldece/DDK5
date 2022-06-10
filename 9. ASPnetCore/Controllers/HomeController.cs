using Microsoft.AspNetCore.Mvc;
namespace webTutorial.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public string GetName()
        {
            return "Çağatay Yıldız";
        }
        public DateTime GetDate()
        {
            return DateTime.Now;
        }
private string Secret(){
            return "pasa doner eylenceli";
        }
    }
}