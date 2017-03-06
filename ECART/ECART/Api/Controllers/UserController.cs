using ECART.Areas.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using One.DbService.Infrastructure;
using ECart.Service.Services.Interfaces;
using ECart.Service.Services;
using AutoMapper;
using ECart.Bo;
using System.ComponentModel.DataAnnotations;
using ECART.Utility;
using ECart.Domain.Utility;

namespace ECART.Api.Controllers
{
    [RoutePrefix("api/v1")]
    public class UserController : BaseController, IApiController<UserViewModel>
    {
        private IUserService service;
        public UserController()
        {
            this.service = new UserService(new UnitOfWork());
        }
        public UserController(IUnitOfWork _uow) : base(_uow)
        {
            this.service = new UserService(_uow);
        }
        [HttpPost]
        [Route("user")]
        [ValidateModel]
        [AllowAnonymous]
        public async Task<IHttpActionResult> Insert(UserViewModel entity)
        {
            try
            {

                entity.UserType = ECart.Bo.Utility.Enums.UserType.Client;
                var id = await this.service.InsertAsync(Mapper.Map<UserBo>(entity));
                Session.User = new UserSession
                {
                    Email = entity.Email,
                    UserId = id,
                    UserType = entity.UserType
                };
                return Ok();
            }
            catch (DbPKViolationException)
            {
                return Content<string>(HttpStatusCode.NotAcceptable,
                    "Email Already there.Please use another Email address or login by exsisting email address.");
            }
            catch (Exception ex)
            {
                return await LogErrors(ex);
            }
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("user/login")]
        public async Task<IHttpActionResult> Login(UserViewModel entity)
        {
            try
            {
                var o = this.service.Login(Mapper.Map<UserBo>(entity));
                Session.User = new UserSession
                {
                    Email = o.Email,
                    UserId = o.Id,
                    UserType = o.UserType
                };
                return Ok();
            }
            catch (ArgumentException)
            {
                return Content<string>(HttpStatusCode.NotAcceptable, "invalied user name or password");
            }
            catch (Exception ex)
            {
                return await LogErrors(ex);
            }
        }
        [HttpPost]
        [UserAuthorize]
        [Route("user/logout")]
        public async Task<IHttpActionResult> Logout()
        {
            try
            {
                Session.SessionDesposed();
                return Ok();
            }
            catch (Exception ex)
            {
                return await LogErrors(ex);
            }
        }

        [HttpPost]
        [Route("user/changepassword")]
        [UserAuthorize]
        public async Task<IHttpActionResult> ChangePassword(string currentPassword, string newPassword)
        {
            try
            {
                var entity = new UserViewModel
                {
                    Email = Session.User.Email,
                    Password = currentPassword
                };
                this.service.ChangePassword(Mapper.Map<UserBo>(entity), newPassword);
                return Ok();
            }
            catch (ArgumentException)
            {
                return Content<string>(HttpStatusCode.NotAcceptable, "invalied current password.");
            }
            catch (Exception ex)
            {
                return await LogErrors(ex);
            }
        }



        [HttpGet]
        [UserAuthorize]
        [Route("user")]
        public async Task<IHttpActionResult> Select()
        {
            try
            {
                return Ok<UserViewModel>(Mapper.Map<UserViewModel>(service.GetByID(Session.User.UserId)));
            }
            catch (Exception ex)
            {
                return await LogErrors(ex);
            }
        }


        [HttpPut]
        [ValidateModel]
        [UserAuthorize]
        [Route("user")]
        public async Task<IHttpActionResult> Update(UserViewModel entity)
        {
            try
            {
                entity.Email = Session.User.Email;
                entity.Id = Session.User.UserId;
                await this.service.UpdateAsync(Mapper.Map<UserBo>(entity));
                return Ok();
            }
            catch (Exception ex)
            {
                return await LogErrors(ex);
            }
        }

        #region Not Actions
        [NonAction]
        public Task<IHttpActionResult> Delete(int id)
        {
            throw new NotImplementedException();
        }
        [NonAction]
        public Task<IHttpActionResult> Select(int skip = 0, int take = 0, string sortBy = "", bool isASC = false, string search = null)
        {
            throw new NotImplementedException();
        }
        [NonAction]
        public Task<IHttpActionResult> SelectById(int id = 0)
        {
            throw new NotImplementedException();
        }
        [NonAction]
        public Task<IHttpActionResult> Update(UserViewModel entity, int id)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
