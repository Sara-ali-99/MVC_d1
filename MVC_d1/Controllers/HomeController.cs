using Microsoft.AspNetCore.Mvc;

namespace MVC_d1.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        { 
            return View ("details");
          
        }
      
    }
}
