using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ECart.Bo.Utility.Enums;

namespace ECart.Bo
{
    public class UserBo
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public UserType UserType { get; set; }
        public DateTime RegDate { get; set; }
    }
}
