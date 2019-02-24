using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace $safeprojectname$.App_Start
{
    public class MappingConfig
    {
        public static void RegisterMaps()
        {
            AutoMapper.Mapper.Initialize(config =>
            {
                //config.CreateMap<trRegistration, SignupViewModel>()
                //    .ForMember(
                //        des => des.Name,
                //        opt => opt.MapFrom(
                //            src => src.Stores.FirstOrDefault().Name
                //            )
                //        )
                //.ForMember(
                //        des => des.Description,
                //        opt => opt.MapFrom(
                //            src => src.Stores.FirstOrDefault().Description
                //            )
                //        );
                
            });
        }
    }
}