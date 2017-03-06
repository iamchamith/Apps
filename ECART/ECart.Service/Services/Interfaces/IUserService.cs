using ECart.Bo;
using One.DbService.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECart.Service.Services.Interfaces
{
    public interface IUserService: IRepositoryRead<UserBo>,IRepositoryUpdateAsync<UserBo>
    {
        UserBo Login(UserBo obj);
        void ChangePassword(UserBo obj, string newPassword);
    }
}
