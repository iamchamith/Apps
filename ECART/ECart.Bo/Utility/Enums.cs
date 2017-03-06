using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Bo.Utility
{
    public class Enums
    {
        public enum UserType
        {
            Oparator, Client
        }

        public enum PaymentMethod { Paypal, Monaris, Chase }

        public enum Category { Laptop, Desktop, Phone, Camara, Others }

        public enum AppRunTime { Debug, Release, UnitTest }

        public enum ErrorTypes { Server, Javascript }
    }
}
