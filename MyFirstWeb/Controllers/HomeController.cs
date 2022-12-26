using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFirstWeb.Models;
using System.Data;
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
        [Route("Home/Privacy")]
        public IActionResult Privacy()
        {
            ViewBag.var1 = "Currently data from Viewbag";
            ViewBag.var2 = DateTime.Now.ToShortTimeString();
            string[] arr = { "Apple", "Mango", "Orange" };

            ViewBag.var3 = arr;
            ViewBag.var4 = new List<string>()
            {
                "Gta",
                "snow",
                "Hill climb",
               
            };
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
                Standard=8
            };

            Student std2 = new Student()
            {
                id = 2,
                name = "Rahul",
                age = 22,
                Standard = 6
            };

            Student std3 = new Student()
            {
                id = 3,
                name = "Shivam",
                age = 20,
                Standard = 9
            };

            Student std4 = new Student()
            {
                id = 4,
                name = "Mohit",
                age = 25,
                Standard = 11
            };

            List<Student> std_list = new List<Student>();
            std_list.Add(std1);
            std_list.Add(std2);
            std_list.Add(std3);
            std_list.Add(std4);


            return View(std_list);
         
        }

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

            Employee aryan = new Employee();
            aryan.name = "aryan Singh";
            aryan.city = "Noida";
            aryan.designation = "Software Engineers";


            ViewBag.var6 = aryan;

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

            Student sumit = new Student();
            sumit.name = "sumit kumar";
            sumit.gender = "Male";
            sumit.standard = 12;
           

            ViewData["var5"] = sumit;

            TempData.Keep("var10");

            return View();

        }


        [Route("Home/Contact")]
        public IActionResult Contact()
        {
            ViewData["var1"] = "ViewData";
            ViewBag.var2 = "viewbag";
            

            string[] arr = { "arya", "sumit", "sonu" };

            TempData["check"] = arr;

            TempData["var10"] = "Temp Data 10";


            return View();
            
         }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}