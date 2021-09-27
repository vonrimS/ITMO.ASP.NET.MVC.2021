using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcCreditApp001.Models
{
    public class Bid
    {
        public virtual int BidId { get; set; }
        [Required]
        [DisplayName("Имя заявителя")]
        public virtual string Name { get; set; }
        [Required]
        [DisplayName("Название кредита")]
        public virtual string CreditHead { get; set; }
        [DisplayName("Дата подачи заявки")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public virtual DateTime bidDate { get; set; }
    }
}
