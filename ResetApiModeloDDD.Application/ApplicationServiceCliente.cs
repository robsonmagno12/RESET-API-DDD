using ResetApiModeloDDD.Application.Dtos;
using ResetApiModeloDDD.Application.Interfaces.Mapper;
using ResetApiModeloDDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace ResetApiModeloDDD.Application
{
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        private readonly IServicesCliente servicesCliente;
        private readonly IMapperCliente mapperCliente;

        public ApplicationServiceCliente(IServicesCliente servicesCliente, IMapperCliente mapperCliente)
        {
            this.servicesCliente = servicesCliente;
            this.mapperCliente = mapperCliente;
        }

        public void Add(ClienteDto clienteDto)
        {
            //convertendo a DTo para enteidade e jogando no BD
            var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
            servicesCliente.Add(cliente);
        }

        public IEnumerable<ClienteDto> GetAll()
        {
            //chamando services que está chamando repositorio que retorna todos os dados uma listagem de clientes cadatrado
            // converte a lista de clientes é ums lista de cliente DTO
            var clientes = servicesCliente.GetAll();
            return mapperCliente.MapperListClientesDto(clientes);
        }

        public ClienteDto GetById(int id)
        {
            var cliente = servicesCliente.GetById(id);
            return mapperCliente.MapperEntityToDto(cliente);
        }

        public void Remove(ClienteDto clienteDto)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
            servicesCliente.Remove(cliente);
        }

        public void Update(ClienteDto clienteDto)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
            servicesCliente.Update(cliente);
        }
    }
}