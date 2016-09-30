using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVSA.Newsletter.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappigs()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMappingProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    }
}
