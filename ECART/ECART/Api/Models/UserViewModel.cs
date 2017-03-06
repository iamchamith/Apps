using System;
using System.ComponentModel.DataAnnotations;
using static ECart.Bo.Utility.Enums;

namespace ECART.Areas.Api.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        public string Password { get; set; }
        [Required]
        public string Name { get; set; }
        public UserType UserType { get; set; }
        public DateTime RegDate { get; set; }
        public UserViewModel()
        {
            UserType = UserType.Client;
        }
    }
}