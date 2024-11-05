using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers{
    public class AnnController: Controller{
        [HttpGet]
        public ActionResult NewAnn(){
            return View();
        }
        [HttpPost]
        public ActionResult NewAnn(Announcement newann){
		    Repository.AddAnnouncement(newann);
            

			return View("ok");


        }
        public ActionResult List(){
            return View(Repository.annlist);
        }
        
        public IActionResult Details(int id){
            return View(Repository.GetElement(id));
        }
    }


}