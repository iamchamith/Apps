using One.DbService.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Service.Services.Interfaces
{
    public interface ICategoryService: IRepositoryRead<string>
    {
        IEnumerable<KeyValuePair<int, string>> Get();
    }
}
