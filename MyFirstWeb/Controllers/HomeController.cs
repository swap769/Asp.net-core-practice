using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFirstWeb.Models;
using System.Diagnostics;
using System.Security.Cryptography.Xml;
using System.Xml.Linq;

namespace MyFirstWeb.Controllers
 
{
    public class HomeController : Controller
    {
    
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("Home/Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("Home/StudentData")]
        public IActionResult StudentData()
        {
            Student std1 = new Student()
            {
                id = 1,
                name = "Harsh",
                age = 21,
            };

            Student std2 = new Student()
            {
                id = 2,
                name = "Rahul",
                age = 22,
            };

            Student std3 = new Student()
            {
                id = 3,
                name = "Shivam",
                age = 20,
            };

            Student std4 = new Student()
            {
                id = 4,
                name = "Mohit",
                age = 25,
            };

            List<Student> std_list = new List<Student>();
            std_list.Add(std1);
            std_list.Add(std2);
            std_list.Add(std3);
            std_list.Add(std4);

            return View(std_list);
         
        }

        //[Route("Home/About/{id?}")]
        //public int About(int id)
        //{
        //    return id;
        //}

        [Route("Home/About/{id?}")]
        public IActionResult About(int id)
        {
            Student std5 = new Student()
            { 
              id=id,
              name="swap",
              age = 25,
            };
           
            List<Student> std_list = new List<Student>();

            std_list.Add(std5);

            return View(std_list);

        }

        [Route("Home/Details")]
        public IActionResult Details()
        {
            ViewData["var1"] = "Viewdata-1";
            ViewData["var2"] = DateTime.Now.ToLongDateString();


            string[] Myarr = { "iphone","mi","samsung"};

            ViewData["var3"] = Myarr;

            ViewData["var4"] = new List<string>()
            {
                "Circket",
                "Football",
                "Hockey"
            };

            return View();
        }

        [Route("Home/Login")]
        public IActionResult Login()
        {
            return View();
        }

        [Route("Home/Registration")]
        public IActionResult Registration()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}