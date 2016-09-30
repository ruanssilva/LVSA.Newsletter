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
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "ViewModelToDomain";
            }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<DestinatarioViewModel, Destinatario>();
            Mapper.CreateMap<EnvioViewModel, Envio>();
            Mapper.CreateMap<LoteViewModel, Lote>();
            Mapper.CreateMap<RemetenteViewModel, Remetente>();
            Mapper.CreateMap<ServidorViewModel, Servidor>();
        }
    }
}
