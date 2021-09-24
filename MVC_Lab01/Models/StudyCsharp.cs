﻿using System;
using System.Text;

namespace MVC_Lab01.Models
{

    public enum AccountType
    {
        Checking,
        Deposit
    }

    public struct BankAccount
    {
        public long accNo;
        public decimal accBal;
        public AccountType accType;

        public override string ToString()
        {
            //string res = String.Format("Номер счета {0}, баланс {1}, тип {2}", accNo, accBal, accType);
            string res = $"Номер счета {accNo}, баланс {accBal}, тип {accType}";
            return res;
        }
    }

    public class StudyCsharp
    {
        
        public static string SetStatus (int age)
        {
            string status = "junior developer";

            if ((age > 2) && (age < 7)) status = "middle developer";
            else if ((age >= 7) && (age < 15)) status = "senior developer";
            else if ((age >= 15)) status = "sensei";

            return status;
        }

        public static string ExeSwitch(string status)
        {
            string res;
            switch (status)
            {
                case "junior developer":
                    res = "Набирайся знаний, ешь сметану и творог"; break;
                case "middle developer":
                    res = "Набирайся опыта, не забывай про знания"; break;
                case "senior developer":
                    res = "Руководи другими (но главное чтобы санитары не заметили)"; break;
                case "sensei":
                    res = "Учи других"; break;
                default:
                    res = "Не знаю что и думать"; break;
            }
            return res;
        }

        public static string GetFunction (double x1, double x2)
        {
            StringBuilder str = new StringBuilder();
            double x = x1;
            do
            {
                str.AppendFormat("x = {0:0.##} : y = {1:0.##};\n", x, Math.Pow(x, 3));
                x = x + 0.5;
            } while (x <= x2);

            return str.ToString();
        }

        public static bool Factorial (int n, out int answer)
        {
            int k;
            int f = 1;
            bool ok = true;

            try
            {

                checked
                {
                    for (k = 2; k <= n; ++k)
                    {
                        f = f * k;
                    }
                }
            }
            catch (Exception ex)
            {
                f = 0;
                ok = false;
            }

            answer = f;
            return ok;
        }
    }
}
