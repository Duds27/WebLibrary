using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DDD.Domain.Entities.Base;
using DDD.Domain.Interfaces.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace DDD.Infra.Persistence.Repositories.Base
{
    public class RepositoryBase<TEntidade, Integer> : IRepositoryBase<TEntidade, Integer>
        where TEntidade : EntityBase
    {
        private readonly LibraryContext _context;

        public RepositoryBase(LibraryContext context)
        {
            _context = context;
        }
         
        public TEntidade Adicionar(TEntidade entidade)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntidade> AdicionarLista(IEnumerable<TEntidade> entidades)
        {
            throw new NotImplementedException();
        }

        public TEntidade Editar(TEntidade entidade)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Func<TEntidade, bool> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntidade> Listar(params Expression<Func<TEntidade, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntidade> ListarEOrdenadosPor<TKey>(Expression<Func<TEntidade, bool>> where, Expression<Func<TEntidade, TKey>> ordem, bool ascendente = true, params Expression<Func<TEntidade, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntidade> ListarOrdenadosPor<TKey>(Expression<Func<TEntidade, TKey>> ordem, bool ascendente = true, params Expression<Func<TEntidade, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntidade> ListarPor(Expression<Func<TEntidade, bool>> where, params Expression<Func<TEntidade, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public TEntidade ObterPor(Func<TEntidade, bool> where, params Expression<Func<TEntidade, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public TEntidade ObterPorId(Integer id, params Expression<Func<TEntidade, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public void Remover(TEntidade entidade)
        {
            throw new NotImplementedException();
        }
    }
}