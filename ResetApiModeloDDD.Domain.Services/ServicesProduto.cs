using ResetApiModeloDDD.Domain.Core.Interfaces.Repositorys;
using ResetApiModeloDDD.Domain.Core.Interfaces.Services;
using ResetApiModeloDDD.Domain.Entitys;

namespace ResetApiModeloDDD.Domain.Services
{
    public class ServicesProduto : ServicesBase<Produto>, IServicesProduto
    {
        private readonly IRepositoryProduto repositoryProduto;

        public ServicesProduto(IRepositoryProduto repositoryProduto) : base(repositoryProduto)
        {
            this.repositoryProduto = repositoryProduto;
        }
    }
}