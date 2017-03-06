using ECart.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECart.Bo.Bo;
using System.Linq.Expressions;
using One.DbService.Infrastructure;
using ECart.Domain.Models;
using AutoMapper;

namespace ECart.Service.Services
{
    public class ErrorService : IErrorService
    {
        private IUnitOfWork uow;
        public ErrorService(IUnitOfWork _uow)
        {
            this.uow = _uow;
        }
        public IEnumerable<ErrorBo> Get(int skip = 0, int take = 0, string sortBy = "", bool isASC = false, string search = null)
        {
            try
            {
                return this.uow.ErrorRepository.Get(null, null, null)
                    .Select(x => AutoMapper.Mapper.Map<ErrorBo>(x)).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
       
        public async Task<int> InsertAsync(ErrorBo entity)
        {
            try
            {
                this.uow.ErrorRepository.Insert(Mapper.Map<Error>(entity));
                await this.uow.SaveAsync();
                return 0;
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Obsolete("NotImplementedException")]
        public Task UpdateAsync(ErrorBo entityToUpdate)
        {
            throw new NotImplementedException();
        }
        [Obsolete("NotImplementedException")]
        public Task DeleteAsync(object id)
        {
            throw new NotImplementedException();
        }
        [Obsolete("NotImplementedException")]
        public ErrorBo GetByID(object id)
        {
            throw new NotImplementedException();
        }
        [Obsolete("NotImplementedException")]
        public IEnumerable<ErrorBo> Get(Expression<Func<ErrorBo, bool>> filter = null, Func<IQueryable<ErrorBo>, IOrderedQueryable<ErrorBo>> orderBy = null, string includeProperties = "")
        {
            throw new NotImplementedException();
        }


    }
}
