using ResetApiModeloDDD.Domain.Core.Interfaces.Repositorys;
using ResetApiModeloDDD.Domain.Core.Interfaces.Services;
using ResetApiModeloDDD.Domain.Entitys;

namespace ResetApiModeloDDD.Domain.Services
{
    public class ServicesCliente : ServicesBase<Cliente>, IServicesCliente
    {
        private readonly IRepositoryCliente repositoryCliente;

        public ServicesCliente(IRepositoryCliente repositoryCliente) : base(repositoryCliente)
        {
            this.repositoryCliente = repositoryCliente;
        }
    }
}