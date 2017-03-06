using ECart.Bo.Bo;
using ECart.Service.Services;
using ECart.Service.Services.Interfaces;
using ECART.Utility;
using One.DbService.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.SessionState;
using static ECart.Bo.Utility.Enums;

namespace ECART.Api.Controllers
{
    public class BaseController : ApiController
    {
        IErrorService error;
        public BaseController(IUnitOfWork _uow)
        {
            error = new ErrorService(_uow);
        }
        public BaseController()
        {
            error = new ErrorService(new UnitOfWork());
        }
        protected async Task<IHttpActionResult> LogErrors(Exception ex, ErrorTypes et = ErrorTypes.Server)
        {

            try
            {
                while (ex.InnerException != null)
                {
                    ex = ex.InnerException;
                }
                await error.InsertAsync(new ErrorBo
                {
                    Date = DateTime.UtcNow,
                    Exception = ex.Message,
                    Message = (et == ErrorTypes.Javascript) ? ex.Message.Split('^')[0] : ex.Message,
                    ErrorStackTrace = (et == ErrorTypes.Javascript) ? ex.Message.Split('^')[1] : ex.StackTrace,
                });
                var err = string.Empty;
#if DEBUG
                err = ex.Message;
#endif
                return Content<string>(HttpStatusCode.InternalServerError, err);
            }
            catch (Exception e)
            {
                return Content<Exception>(HttpStatusCode.InternalServerError, e);
            }
        }
    }
}
