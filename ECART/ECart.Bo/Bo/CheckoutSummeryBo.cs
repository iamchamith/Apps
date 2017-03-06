using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ECart.Bo.Utility.Enums;

namespace ECart.Bo
{
    public class CheckoutSummeryBo
    {
        public int InvoiceId { get; set; }
        public int UserId { get; set; }
        public decimal TotalAmount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string CardNumber { get; set; }
        public DateTime CheckoutDate { get; set; }
    }
}
