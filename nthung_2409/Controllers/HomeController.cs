using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace nthung_2409.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Personal Information:";
            ViewBag.Name = "Nguyễn Tuấn Hưng";
            ViewBag.Age = 21;
            ViewBag.Job = "Programmer";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About me:";
            ViewBag.Description = "My name is Nguyen Tuan Hung, you can call me Josee or J, I am 21 years old and currently studying and working at UNETI,";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "My contact:";
            ViewBag.Email = "hban1567@gmail.com";
            ViewBag.Phone = "0943213826";
            return View();
        }

        public ActionResult GiaiPhuongTrinh(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;
            string message;

            if (a == 0)
            {
                message = "Đây không phải là phương trình bậc hai.";
            }
            else
            {
                if (delta > 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    message = $"Phương trình bậc 2: {a}x^2 + {b}x + {c} = 0 có 2 nghiệm phân biệt x1 = {x1} và x2 = {x2}.";
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    message = $"Phương trình bậc 2: {a}x^2 + {b}x + {c} = 0 có 1 nghiệm kép x1 = x2 = {x}.";
                }
                else
                {
                    message = $"Phương trình bậc 2: {a}x^2 + {b}x + {c} = 0 vô nghiệm.";
                }
            }

            ViewBag.Message = message;
            return View();
        }
    }
}