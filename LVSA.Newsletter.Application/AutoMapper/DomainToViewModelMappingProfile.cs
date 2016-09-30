using AutoMapper;
using LVSA.Newsletter.Application.ViewModels;
using LVSA.Newsletter.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVSA.Newsletter.Application.AutoMapper
{
    class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "DomainToViewModel";
            }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Destinatario, DestinatarioViewModel>(); 
            Mapper.CreateMap<Envio, EnvioViewModel>(); 
            Mapper.CreateMap<Lote, LoteViewModel>(); 
            Mapper.CreateMap<Remetente, RemetenteViewModel>(); 
            Mapper.CreateMap<Servidor, ServidorViewModel>(); 
        }
    }
}
