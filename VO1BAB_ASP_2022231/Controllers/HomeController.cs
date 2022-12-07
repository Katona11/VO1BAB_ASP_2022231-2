using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Xml.Linq;
using VO1BAB_ASP_2022231.Data;
using VO1BAB_ASP_2022231.Models;

namespace VO1BAB_ASP_2022231.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ICarsLogic logic;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        

        public HomeController(ILogger<HomeController> logger, ICarsLogic logic, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _logger = logger;
            this.logic = logic;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ListCar()
        {
            return View(this.logic.ReadAll());
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [Authorize(Roles ="Admin")]
        [HttpPost]
        public IActionResult Create(Cars item)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View(item);
            //}
            logic.Create(item);
            return RedirectToAction(nameof(ListCar));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Authorize(Roles ="Admin")]
        public IActionResult Delete(int id)
        {
            this.logic.Delete(id);
            return RedirectToAction(nameof(ListCar));
        }

        [Authorize(Roles ="Admin")]
        [HttpPost]
        public IActionResult Update(Cars item)
        {
            logic.Update(item);
            return RedirectToAction(nameof(ListCar));

        }
        [Authorize(Roles = "Admin")]
        public IActionResult Update(int id)
        {
            var item = logic.Read(id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Filter(int number,int brand)
        {
            IEnumerable<Cars> filteredlist = logic.ReadAll();
            if (number != null)
            {
                filteredlist = filteredlist.Where(t => t.Year == number);
            }
            if (brand != 0)
            {
                filteredlist = filteredlist.Where(t => t.CarBrandID == brand);
            }
            return View("ListCar",filteredlist);




        }
        [Authorize(Roles ="Admin")]
        public IActionResult Users()
        {
            return View(_userManager.Users);
        }
        [Authorize]
        public IActionResult Theusernumber()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userName = this.User.FindFirstValue(ClaimTypes.Name);
            string[] names = new string[2];
            names[0] = userId;
            names[1]= userName;
            
            return View(names);
        }

        [HttpPost]
        public IActionResult Sort(string name)
        {
            IEnumerable<Cars> filteredlist = logic.ReadAll();
            if (name == "Year")
            {
                filteredlist = filteredlist.OrderBy(t => t.Year);
            }
            else if (name == "HP")
            {
                filteredlist = filteredlist.OrderBy(t => t.PerformanceInHP);
            }
            else if (name == "Name")
            {
                filteredlist = filteredlist.OrderBy(t => t.carbrand.Name).ThenBy(t=>t.Type);
            }

            return View("ListCar", filteredlist);
        }
        [HttpPost]
        public IActionResult Search(string id)
        {
            IEnumerable<Cars> filteredlist = logic.ReadAll();
            if (id  !=null)
            {
                id = id.ToUpper();
                filteredlist = filteredlist.Where(t => t.CarsID.ToString().Contains(id) || t.CarBrandID.ToString().Contains(id) || t.Year.ToString().Contains(id) || t.PerformanceInHP.ToString().Contains(id) || t.LicensePlateNumber.ToUpper().Contains(id) || t.Type.ToUpper().Contains(id)|| t.carbrand.Name.ToUpper().Contains(id));
                return View("ListCar", filteredlist);
            }
            else
            {
                return View("ListCar", logic.ReadAll());
            }
            
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DelegeteAdmin()
        {
            var principal = this.User;
            var user = await _userManager.GetUserAsync(principal);
            var role = new IdentityRole()
            {
                Name= "Admin"
            };
            if (!await _roleManager.RoleExistsAsync("Admin"))
            {
                await _roleManager.CreateAsync(role);
            }
             await _userManager.AddToRoleAsync(user, "Admin");
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GrantAdmin(string uid)
        {
            var user = _userManager.Users.FirstOrDefault(t => t.UserName == uid);
            await _userManager.AddToRoleAsync(user, "Admin");
            return RedirectToAction(nameof(Users));
        }


    }
}