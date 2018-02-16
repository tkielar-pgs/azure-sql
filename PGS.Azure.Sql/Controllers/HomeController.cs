using Microsoft.AspNetCore.Mvc;

namespace PGS.Azure.Sql.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();        
    }
}
