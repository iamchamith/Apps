using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Bo
{
    public class CheckoutBo
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int ItemPrice { get; set; }
        public int NumberOfUnits { get; set; }
        public int BatchId { get; set; }
    }
}
