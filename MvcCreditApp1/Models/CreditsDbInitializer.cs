﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;

namespace MvcCreditApp1.Models
{
    public class CreditsDbInitializer : DropCreateDatabaseIfModelChanges<CreditContext>
    {
        protected override void Seed(CreditContext context)
        {
            context.Credits.Add(new Credit{ Head = "Ипотечныйкредит", Period = 10, Sum = 1000000, Procent = 15 });
            context.Credits.Add(new Credit{ Head = "Образовательныйкредит", Period = 7, Sum = 300000, Procent = 10 });
            context.Credits.Add(new Credit{ Head = "Потребительскийкредит", Period = 5, Sum = 500000, Procent = 19 });

            base.Seed(context);
        }

    }
}
