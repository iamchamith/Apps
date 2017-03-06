using AutoMapper;
using ECart.Bo;
using ECart.Bo.Bo;
using ECart.Domain.Models;
using ECART.Areas.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECART.App_Start
{
    public class AutomapperConfig
    {
        public static void Register()
        {
            //item
            {
                Mapper.CreateMap<ItemViewModel, ItemBo>();
                Mapper.CreateMap<ItemBo, ItemViewModel>();

                Mapper.CreateMap<ItemBo, Item>();
                Mapper.CreateMap<Item, ItemBo>();
            }
            //user
            {
                Mapper.CreateMap<UserViewModel, UserBo>();
                Mapper.CreateMap<UserBo, UserViewModel>();

                Mapper.CreateMap<UserBo, User>();
                Mapper.CreateMap<User, UserBo>();
            }
            //errors
            {
                Mapper.CreateMap<Error, ErrorBo>();
                Mapper.CreateMap<ErrorBo, Error>();
            }
        }
    }
}