using Microsoft.AspNetCore.Mvc;
using VO1BAB_ASP_2022231.Data;

namespace VO1BAB_ASP_2022231.Controllers
{
    public class ViewController : Controller
    {
        ICarsRepository repo;

        public ViewController(ICarsRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public IActionResult ViewCar(int id)
        {
            var item = repo.Read(id);
            return View(item);
        }
    }
}
