using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Lab01.Models;

namespace MVC_Lab01.Controllers
{
    public class HomeController : Controller
    {
        private static PersonRepository db = new PersonRepository();

        //public string Index(string hel)
        //{

        //    //string Greeting = ModelClass.ModelHello() + ", " + hel;
        //    //return Greeting;


        //    //string res = ExeEnum();
        //    //return res;

        //    //string res = ExeStruct();

        //    //string res = StudyCsharp.SetStatus(3);

        //    //string res = StudyCsharp.ExeSwitch(StudyCsharp.SetStatus(3));

        //    //string res = StudyCsharp.GetFunction(0, 9);


        //    //string res = ExeFactorial(5);

        //    //Triangle triangle1 = new Triangle(3, 5, 6);

        //    //string res = ExeTriangle(triangle1);

        //    //Circle circle = new Circle(3);

        //    //string res = ExeCircle(circle);

        //    //string res = ExePoli();

        //    string res = ExeCollection();

        //    return res;
        //}

        [HttpGet]
        public ViewResult InputData() { 
            return View(); 
        }

        [HttpPost]
        public ViewResult InputData(Person p)
        {
            db.AddPerson(p);
            return View("Hello",  p);
        }


        public string ExeEnum()
        {
            AccountType goldAccount;
            AccountType platinumAccount;

            goldAccount = AccountType.Checking;
            platinumAccount = AccountType.Deposit;

            string res1 = String.Format("Тип банковского чета {0}", goldAccount);
            string res2 = String.Format("Тип банковского чета {0}", platinumAccount);

            string res = res1 + "\n" + res2;
            return res;
        }

        public string ExeStruct()
        {
            BankAccount goldBankAccount;
            goldBankAccount.accType = AccountType.Checking;
            goldBankAccount.accBal = (decimal)3200.00;
            goldBankAccount.accNo = 123;

            //string res = String.Format("Номер счета {0}, баланс {1}, тип {2}", goldBankAccount.accNo, goldBankAccount.accBal, goldBankAccount.accType);

            string res = String.Format("Информация о банковском счете: {0}", goldBankAccount);

            return res;
        }


        public string ExeFactorial(int x)
        {
            int f;
            bool ok = StudyCsharp.Factorial(x, out f);

            if (ok)
                return String.Format("Факториал числа {0} равен {1}", x, f);
            else
                return "Невозможно вычислить факториал";
        }


        public string ExeTriangle(Triangle triangle) => $"Площадь фигуры {triangle.Name} равна: {triangle.Area}";

        public string ExeCircle(Circle circle) => $"Площадь фигуры {circle.Name} равна: {circle.Area:0.##}";


        public string ExePoli()
        {
            StringBuilder str = new StringBuilder();

            Shape[] shapes =
            {
                new Triangle (1,2,3),
                new Circle(5),
                new Triangle(5,2,88)
            };

            foreach(Shape sh in shapes)
            {
                str.AppendFormat("Это фигура {0}", sh.Name + "\n");
            }

            return str.ToString();

        }


        public string ExeCollection()
        {
            List<Circle> cirs = new List<Circle>
            {
                new Circle(12),
                new Circle(5),
                new Circle(3),
                new Circle(11)
            };

            cirs.Add(new Circle(31));
            cirs.Sort();

            StringBuilder str = new StringBuilder();
            foreach (Shape item in cirs)
            {
                str.AppendFormat("Это фигура {0}", item.Name + "\n");
            }

            return str.ToString();
        }

        //Triangle triangle = new Triangle(3, 5, 6);



        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour; 
            ViewBag.Greeting = hour < 12 ? "Доброе утро" : "Добрый день"; 
            ViewData["Mes"] = "хорошего настроения"; 
            return View();
        }

        public ViewResult OutputData()
        {
            ViewBag.Pers = db.GetAllPersons;
            ViewBag.Count = db.NumOfPerson;
            return View("ListPerson");
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
