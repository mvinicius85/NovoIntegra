using NovoIntegra.Core.Domain.Interfaces.Repository;
using NovoIntegra.Core.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NovoIntegra.Core.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {

        private readonly IRepository<TEntity> _repository;


        public ServiceBase(IRepository<TEntity> repository)
        {
            _repository = repository;
        }


        public void Adicionar(TEntity obj)
        {
            _repository.Adicionar(obj);
        }

        public void Atualizar(TEntity obj)
        {
            _repository.Atualizar(obj);
        }

        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return _repository.Buscar(predicate);
        }



        public TEntity ObterPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public TEntity ObterPorId(string id)
        {
            return _repository.ObterPorId(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return _repository.ObterTodos();
        }

        public void Remover(TEntity obj)
        {
            _repository.Remover(obj);
        }

        public void Remover(int id)
        {
            _repository.Remover(id);
        }
    }
}
