using ECART.Areas.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;

namespace ECART.Api.Controllers
{
    public class CartController : BaseController, IApiController<List<CheckoutViewModel>>
    {

        public Task<IHttpActionResult> Insert(List<CheckoutViewModel> entity)
        {
            throw new NotImplementedException();
        }



        public Task<IHttpActionResult> Select(int skip = 0, int take = 0, string sortBy = "", bool isASC = false, string search = null)
        {
            throw new NotImplementedException();
        }

        #region noneActions
        [NonAction]
        public Task<IHttpActionResult> Update(List<CheckoutViewModel> entity, int id)
        {
            throw new NotImplementedException();
        }
        [NonAction]
        public Task<IHttpActionResult> Delete(int id)
        {
            throw new NotImplementedException();
        }
        [NonAction]
        public Task<IHttpActionResult> Select()
        {
            throw new NotImplementedException();
        }

        public Task<IHttpActionResult> Update(List<CheckoutViewModel> entity)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
