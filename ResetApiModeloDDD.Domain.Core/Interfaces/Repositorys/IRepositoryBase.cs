using System.Collections.Generic;

namespace ResetApiModeloDDD.Domain.Core.Interfaces.Repositorys
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        void Update(TEntity obj);

        void Remove(TEntity obj);

        //metodo de busca  IEnumerable muito melhor que um LIST pois ocupa menos memoria
        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);


    }
}
