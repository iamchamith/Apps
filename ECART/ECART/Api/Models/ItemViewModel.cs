using System.ComponentModel.DataAnnotations;
using static ECart.Bo.Utility.Enums;

namespace ECART.Areas.Api.Models
{
    public class ItemViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Image { get; set; }
        public Category Category { get; set; }
        public ItemViewModel()
        {
            Image = "no.jpg";
            Category = Category.Others;
        }
    }
}