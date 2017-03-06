using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECart.Domain.Models
{
    [Table("Checkouts")]
    public class Checkout
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int ItemId { get; set; }
        [Required]
        [DefaultValue(0.00)]
        public int ItemPrice { get; set; }
        [Required]
        [DefaultValue(0)]
        public int NumberOfUnits { get; set; }
        [Required]
        public int BatchId { get; set; }
        [ForeignKey("BatchId")]
        public virtual CheckoutSummery CheckoutSummery { get; set; }
        [ForeignKey("ItemId")]
        public virtual Item Item { get; set; }
    }
}
