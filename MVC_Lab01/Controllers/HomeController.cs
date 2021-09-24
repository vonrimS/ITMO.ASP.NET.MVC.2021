using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Lab01.Models;

namespace MVC_Lab01.Controllers
{
    public class HomeController : Controller
    {

        public string Index(string hel)
        {

            //string Greeting = ModelClass.ModelHello() + ", " + hel;
            //return Greeting;


            //string res = ExeEnum();
            //return res;

            //string res = ExeStruct();

            //string res = StudyCsharp.SetStatus(3);

            //string res = StudyCsharp.ExeSwitch(StudyCsharp.SetStatus(3));

            //string res = StudyCsharp.GetFunction(0, 9);


            string res = ExeFactorial(5);

            return res;
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


        public string ExeFactorial (int x)
        {
            int f;
            bool ok = StudyCsharp.Factorial(x, out f);

            if (ok)
                return String.Format("Факториал числа {0} равен {1}", x, f);
            else
                return "Невозможно вычислить факториал";
        }


        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        //public IActionResult Index()
        //{
        //    return View();
        //}

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
