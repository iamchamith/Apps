using ECart.Bo;
using ECart.Bo.Bo;
using One.DbService.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Service.Services.Interfaces
{
    public interface ICartService : IRepositoryRead<CheckoutBo>, IRepositoryUpdateAsync<CheckoutBo>
    {
    }
}
