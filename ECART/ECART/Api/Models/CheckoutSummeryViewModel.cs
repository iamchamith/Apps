using System;
using System.ComponentModel.DataAnnotations;
using static ECart.Bo.Utility.Enums;

namespace ECART.Areas.Api.Models
{
    public class CheckoutSummeryViewModel
    {
        [Required]
        public int InvoiceId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public decimal TotalAmount { get; set; }
        [Required]
        public PaymentMethod PaymentMethod { get; set; }
        [Required]
        public string CardNumber { get; set; }
        [Required]
        public DateTime CheckoutDate { get; set; }
    }
}