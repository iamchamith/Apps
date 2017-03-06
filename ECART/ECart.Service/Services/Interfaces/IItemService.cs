using ECart.Bo;
using One.DbService.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Service.Services.Interfaces
{
    public interface IItemService: IRepositoryRead<ItemBo>, IRepositoryUpdateAsync<ItemBo>
    {
    }
}
