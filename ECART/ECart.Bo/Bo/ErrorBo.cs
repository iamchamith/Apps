using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Bo.Bo
{
    public class ErrorBo
    {
        public int Id { get; set; }
        public string Exception { get; set; }
        public string Message { get; set; }
        public string ErrorStackTrace { get; set; }
        public DateTime Date { get; set; }
    }
}
