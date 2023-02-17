using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace SoulSocks.Controllers
{
    public class SockController : Controller
    {

        // 
        // GET: /Sock/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /Sock/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}