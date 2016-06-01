using AutoMapper;
using ProjectConsultants.Entity;
using ProjectConsultants.UI.ViewModel;

namespace ProjectConsultants.Api.App_Start
{
    public static class MapperConfig
    {
        public static UserEntity ConvertChangePasswordModelToEntity(ChangePasswordViewModel changePasswordViewModel)
        {
            Mapper.CreateMap<ChangePasswordViewModel, UserEntity>();
            return Mapper.Map<UserEntity>(changePasswordViewModel);            
        }
    }
}