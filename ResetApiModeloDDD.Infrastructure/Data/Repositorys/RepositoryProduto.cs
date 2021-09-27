using ResetApiModeloDDD.Domain.Core.Interfaces.Repositorys;
using ResetApiModeloDDD.Domain.Entitys;

namespace ResetApiModeloDDD.Infrastructure.Data.Repositorys
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto 
    {
        private readonly SqlContext sqlContext;

        public RepositoryProduto(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }

    }
}
