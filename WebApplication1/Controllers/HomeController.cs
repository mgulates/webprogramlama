using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class HomeController : Controller{
        public IActionResult Index(){
            ViewBag.AnnCount=Repository.annlist.Count;
            return View(Repository.annlist);
        }
    }
}