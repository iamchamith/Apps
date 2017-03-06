using ECART.Areas.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using ECart.Service.Services.Interfaces;
using One.DbService.Infrastructure;
using ECart.Service.Services;
using ECART.Utility;
using AutoMapper;
using ECart.Bo;
using ECart.Domain.Utility;

namespace ECART.Api.Controllers
{
    [RoutePrefix("api/v1")]
    public class ItemsController : BaseController, IApiController<ItemViewModel>
    {
        private IItemService service;
        private ICategoryService categoryService;
        public ItemsController()
        {
            this.service = new ItemService(new UnitOfWork());
        }
        public ItemsController(IUnitOfWork _uow) : base(_uow)
        {
            this.service = new ItemService(_uow);
        }
        [HttpDelete]
        [UserAuthorize(Roles = "admin")]
        [Route("items/{id:int}")]
        public async Task<IHttpActionResult> Delete(int id)
        {
            try
            {
                await this.service.DeleteAsync(id);
                return Ok();
            }
            catch (DbRowNotFoundException)
            {
                return Content<string>(HttpStatusCode.NotFound, "entity not found");
            }
            catch (Exception ex)
            {
                return await LogErrors(ex);
            }
        }
        [HttpPost]
        [ValidateModel]
        [UserAuthorize(Roles = "admin")]
        [Route("items")]
        public async Task<IHttpActionResult> Insert(ItemViewModel entity)
        {
            try
            {
                var id = await this.service.InsertAsync(Mapper.Map<ItemBo>(entity));
                return Ok<int>(id);
            }
            catch (Exception ex)
            {
                return await LogErrors(ex);
            }
        }
        //cart show
        [HttpGet]
        [AllowAnonymous]
        [Route("items")]
        public async Task<IHttpActionResult> Select(int skip = 0, int take = 0, string sortBy = "", bool isASC = false, string search = null)
        {
            try
            {
                return Ok<IEnumerable<ItemViewModel>>(this.service.Get(skip, take, sortBy, isASC, search).Select(x => AutoMapper.Mapper.Map<ItemViewModel>(x)).ToList());
            }
            catch (Exception ex)
            {
                return await LogErrors(ex);
            }
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("items/{id:int}")]
        public async Task<IHttpActionResult> SelectById(int id)
        {
            try
            {
                return Ok<ItemViewModel>(Mapper.Map<ItemViewModel>(this.service.GetByID(id)));
            }
            catch (DbRowNotFoundException)
            {
                return Content<string>(HttpStatusCode.NotFound, "entity not found");
            }
            catch (Exception ex)
            {
                return await LogErrors(ex);
            }
        }
        [HttpPut]
        [UserAuthorize(Roles = "admin")]
        [Route("items")]
        public async Task<IHttpActionResult> Update(ItemViewModel entity)
        {
            try
            {
                await this.service.UpdateAsync(Mapper.Map<ItemBo>(entity));
                return Ok();
            }
            catch (DbRowNotFoundException)
            {
                return Content<string>(HttpStatusCode.NotFound, "entity not found");
            }
            catch (Exception ex)
            {
                return await LogErrors(ex);
            }
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("categories")]
        public async Task<IHttpActionResult> Select()
        {
            try
            {
                categoryService = new CategoryService();
                return Ok<List<KeyValuePair<int, string>>>(categoryService.Get().ToList());
            }
            catch (Exception ex)
            {
                return await LogErrors(ex);
            }

        }

        public Task<IHttpActionResult> Update(ItemViewModel entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
