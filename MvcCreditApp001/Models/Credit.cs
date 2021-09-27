using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcCreditApp001.Models
{

    public class Credit
    {
        public virtual int CreditId { get; set; }
        [Required]
        [DisplayName("Наименование кредита")]
        public virtual string Head { get; set; }
        [Required]
        [DisplayName("Срок кредитования")]
        public virtual int Period { get; set; }
        [Required]
        [DisplayName("Тело кредита")]
        public virtual int Sum { get; set; }
        [Required]
        [DisplayName("Интерес банка")]
        public virtual int Procent { get; set; }

    }
}
