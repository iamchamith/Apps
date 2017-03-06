using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static ECart.Bo.Utility.Enums;

namespace ECart.Domain.Models
{
    [Table("Items")]
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        [DefaultValue(0.00)]
        public decimal Price { get; set; }
        [DefaultValue(Category.Others)]
        public Category Category { get; set; }
        [Required]
        [DefaultValue("no.jpg")]
        public string Image { get; set; }
    }
}
