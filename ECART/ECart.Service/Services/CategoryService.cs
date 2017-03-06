using ECart.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using static ECart.Bo.Utility.Enums;
using One.DbService.Infrastructure;

namespace ECart.Service.Services
{
    public class CategoryService : ICategoryService
    {
     
        public IEnumerable<KeyValuePair<int, string>> Get()
        {
            try
            {
                var lst = new List<KeyValuePair<int, string>>();
                foreach (Category foo in Enum.GetValues(typeof(Category)))
                {
                    lst.Add(new KeyValuePair<int, string>((int)foo, foo.ToString()));
                }
                return lst;
            }
            catch { throw; }
        }

        public IEnumerable<string> Get(int skip = 0, int take = 0, string sortBy = "", bool isASC = false, string search = null)
        {
            throw new NotImplementedException();
        }

        [Obsolete("NotImplementedException")]
        public string GetByID(object id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<string> IRepositoryRead<string>.Get(Expression<Func<string, bool>> filter, Func<IQueryable<string>, IOrderedQueryable<string>> orderBy, string includeProperties)
        {
            throw new NotImplementedException();
        }
    }
}
