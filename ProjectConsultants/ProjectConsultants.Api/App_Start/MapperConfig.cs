using ProjectConsultants.Entity;
using ProjectConsultants.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectConsultants.Api.App_Start
{
    public static class MapperConfig
    {
        public static void RegisterMaps()
        {
            AutoMapper.Mapper.Initialize(config =>
            {
                config.CreateMap<UserEntity, ChangePasswordViewModel>();
            });
        }     
    }
}