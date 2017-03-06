using ECart.Service.Services.Interfaces;
using One.DbService.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECart.Bo;
using System.Linq.Expressions;
using AutoMapper;
using ECart.Domain.Models;
using ECart.Domain.Utility;

namespace ECart.Service.Services
{
    public class ItemService : BaseService, IItemService
    {
        private IUnitOfWork uow;
        public ItemService(IUnitOfWork _uow)
        {
            this.uow = _uow;
        }

        public async Task DeleteAsync(object id)
        {
            try
            {
                this.uow.ItemRepository.Delete(id);
                await this.uow.SaveAsync();
            }
            catch (Exception ex)
            {
                throw HandleException(ex);
            }
        }


        public IEnumerable<ItemBo> Get(int skip = 0, int take = 0, string sortBy = "", bool isASC = false, string search = null)
        {
            try
            {
                return this.uow.ItemRepository.Get(null, null, "").Select(x => AutoMapper.Mapper.Map<ItemBo>(x)).ToList();
            }
            catch (Exception ex)
            {
                throw HandleException(ex);
            }
        }

        public ItemBo GetByID(object id)
        {
            try
            {
                return Mapper.Map<ItemBo>(this.uow.ItemRepository.GetByID(id));
            }
            catch (Exception ex)
            {
                throw HandleException(ex);
            }
        }

        public async Task<int> InsertAsync(ItemBo entity)
        {
            try
            {
                var o = Mapper.Map<Item>(entity);
                this.uow.ItemRepository.Insert(o);
                await this.uow.SaveAsync();
                return o.Id;
            }
            catch (Exception ex)
            {
                throw HandleException(ex);
            }
        }

        public async Task UpdateAsync(ItemBo entityToUpdate)
        {
            try
            {
                this.uow.ItemRepository.Update(Mapper.Map<Item>(entityToUpdate));
                await this.uow.SaveAsync();
            }
            catch (Exception ex)
            {
                throw HandleException(ex);
            }
        }

        [Obsolete("NotImplementedException")]
        public IEnumerable<ItemBo> Get(Expression<Func<ItemBo, bool>> filter = null, Func<IQueryable<ItemBo>, IOrderedQueryable<ItemBo>> orderBy = null, string includeProperties = "")
        {
            throw new NotImplementedException();
        }

    }
}
