using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCreditApp001.Models
{

    public class Credit
    {
        public virtual int CreditId { get; set; }
        public virtual string Head { get; set; }
        public virtual int Period { get; set; }
        public virtual int Sum { get; set; }
        public virtual int Procent { get; set; }

    }
}
