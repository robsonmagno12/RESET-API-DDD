using System.Collections.Generic;

namespace ResetApiModeloDDD.Domain.Core.Interfaces.Services
{
    public interface IServicesBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        void Update(TEntity obj);

        void Remove(TEntity obj);

        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);
    }
}