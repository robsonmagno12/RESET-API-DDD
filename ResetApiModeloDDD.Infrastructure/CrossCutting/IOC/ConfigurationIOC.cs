using Autofac;
using ResetApiModeloDDD.Application;
using ResetApiModeloDDD.Application.Interfaces;
using ResetApiModeloDDD.Application.Interfaces.Mapper;
using ResetApiModeloDDD.Application.Mapper;
using ResetApiModeloDDD.Domain.Core.Interfaces.Repositorys;
using ResetApiModeloDDD.Domain.Core.Interfaces.Services;
using ResetApiModeloDDD.Domain.Services;
using ResetApiModeloDDD.Infrastructure.Data.Repositorys;

namespace ResetApiModeloDDD.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();
            builder.RegisterType<ServicesCliente>().As<IServicesCliente>();
            builder.RegisterType<ServicesProduto>().As<IServicesProduto>();
            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
            builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();

            #endregion IOC
        }
    }
}