using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static ECart.Bo.Utility.Enums;

namespace ECart.Domain.Models
{
    [Table("CheckoutSummerys")]
    public class CheckoutSummery
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
