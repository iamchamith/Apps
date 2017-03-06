using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ECart.Domain.Models
{
    [Table("Errors")]
    public class Error
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Exception { get; set; }
        [Required]
        public string Message { get; set; }
        public string ErrorStackTrace { get; set; }
        public DateTime Date { get; set; }
    }
}
