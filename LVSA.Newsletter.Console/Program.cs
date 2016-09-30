using LVSA.Newsletter.Application;
using LVSA.Newsletter.Application.Interfaces;
using LVSA.Newsletter.Application.ViewModels;
using LVSA.Newsletter.Domain;
using LVSA.Newsletter.Domain.Interfaces.Repository;
using LVSA.Newsletter.Domain.Interfaces.Services;
using LVSA.Newsletter.Domain.Services;
using LVSA.Newsletter.Infrastructure.Data.Repository.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LVSA.Newsletter.Console
{
    class Program
    {
        private static IServidorAppService _servidorAppService { get; set; }
        private static IServidorService _servidorService { get; set; }
        private static IServidorRepository _servidorRepository { get; set; }

        public Program()
        {
            
        }

        static void Main(string[] args)
        {
            LVSA.Newsletter.Application.AutoMapper.AutoMapperConfig.RegisterMappigs();

            _servidorRepository = new ServidorRepository();
            _servidorService = new ServidorService(_servidorRepository);
            _servidorAppService = new ServidorAppService(_servidorService);

            ServidorViewModel model = _servidorAppService.Filtrar(f => true).FirstOrDefault();


            ReadKey();
        }
    }
}
