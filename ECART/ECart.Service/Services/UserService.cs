using ECart.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECart.Bo;
using System.Linq.Expressions;
using One.DbService.Infrastructure;
using AutoMapper;
using ECart.Domain.Models;
using System.Data.Entity.Infrastructure;

namespace ECart.Service.Services
{
    public class UserService : BaseService, IUserService
    {
        private IUnitOfWork uow;
        public UserService(IUnitOfWork _uow)
        {
            this.uow = _uow;
        }
        [Obsolete("Register")]
        public async Task<int> InsertAsync(UserBo entity)
        {
            try
            {
                entity.RegDate = DateTime.UtcNow;
                entity.Email = entity.Email.ToLower().Trim();
                User obj = Mapper.Map<User>(entity);
                this.uow.UserRepository.Insert(obj);
                await this.uow.SaveAsync();
                return obj.Id;
            }
            catch (Exception ex)
            {
                throw HandleException(ex);
            }
        }
        public UserBo Login(UserBo obj)
        {
            try
            {
                var objx = this.uow.Context.Users.FirstOrDefault(p => p.Email.Equals(obj.Email.ToLower().Trim())
                       && p.Password == obj.Password);
                if (objx == null)
                {
                    throw new ArgumentException();
                }
                return Mapper.Map<UserBo>(objx);
            }
            catch (Exception ex)
            {
                throw HandleException(ex);
            }
        }

        public void ChangePassword(UserBo obj, string newPassword)
        {
            try
            {
                User o = Mapper.Map<User>(Login(obj));
                var e = this.uow.Context.Users.First(p => p.Email == obj.Email);
                e.Password = newPassword;
                this.uow.SaveAsync();
            }
            catch (ArgumentException) { throw; }
            catch (Exception ex)
            {
                throw HandleException(ex);
            }
        }
        public UserBo GetByID(object id)
        {
            try
            {
                return Mapper.Map<UserBo>(this.uow.UserRepository.GetByID(id));
            }
            catch (Exception ex)
            {
                throw HandleException(ex);
            }
        }
        public async Task UpdateAsync(UserBo entityToUpdate)
        {
            try
            {
                var o = this.uow.Context.Users.First(p => p.Id == entityToUpdate.Id);
                o.Name = entityToUpdate.Name;
                await this.uow.SaveAsync();
            }
            catch (Exception ex)
            {
                throw HandleException(ex);
            }
        }
        [Obsolete("NotImplementedException")]
        public Task DeleteAsync(object id)
        {
            throw new NotImplementedException();
        }
        [Obsolete("NotImplementedException")]
        public IEnumerable<UserBo> Get(Expression<Func<UserBo, bool>> filter = null, Func<IQueryable<UserBo>, IOrderedQueryable<UserBo>> orderBy = null, string includeProperties = "")
        {
            throw new NotImplementedException();
        }
        [Obsolete("NotImplementedException")]
        public IEnumerable<UserBo> Get(int skip = 0, int take = 0, string sortBy = "", bool isASC = false, string search = null)
        {
            throw new NotImplementedException();
        }
    }
}
