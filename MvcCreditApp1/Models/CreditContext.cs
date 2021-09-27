
//using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCreditApp1.Models
{
    public class CreditContext : DbContext
    {

        public DbSet<Credit> Credits { get; set; }
        
        public DbSet<Bid> Bids { get; set; }
    }
}
