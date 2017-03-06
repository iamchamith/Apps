using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ECART.Api.Controllers
{
    public interface IApiController<T> where T : class
    {
        Task<IHttpActionResult> Insert(T entity);
        Task<IHttpActionResult> Update(T entity, int id);
        Task<IHttpActionResult> Update(T entity);
        Task<IHttpActionResult> Delete(int id);
        Task<IHttpActionResult> Select();
        Task<IHttpActionResult> Select(int skip = 0, int take = 0, string sortBy = "", bool isASC = false, string search = null);
    }
}
