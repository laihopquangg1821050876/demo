using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace demo.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View() ;
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome()
        {
            return View() ;
        }
    }
}