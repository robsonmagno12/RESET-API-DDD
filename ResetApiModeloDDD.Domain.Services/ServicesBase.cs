using ResetApiModeloDDD.Domain.Core.Interfaces.Repositorys;
using ResetApiModeloDDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace ResetApiModeloDDD.Domain.Services
{
    public class ServicesBase<TEntity> : IServicesBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repository;

        public ServicesBase(IRepositoryBase<TEntity> repository)
        {
            this.repository = repository;
        }

        public void Add(TEntity obj)
        {
            repository.Add(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return repository.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            repository.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            repository.Update(obj);
        }
    }
}