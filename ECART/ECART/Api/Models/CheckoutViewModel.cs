using System.ComponentModel.DataAnnotations;

namespace ECART.Areas.Api.Models
{
    public class CheckoutViewModel
    {
        public int Id { get; set; }
        [Required]
        public int ItemId { get; set; }
        [Required]
        public int ItemPrice { get; set; }
        [Required]
        public int NumberOfUnits { get; set; }
        [Required]
        public int BatchId { get; set; }
    }
}