using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDD.Domain.Entities;
using DDD.Domain.Entities.Base;
using DDD.Domain.Interfaces.Repositories;
using DDD.Infra.Persistence.Repositories.Base;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DDD.Infra.Persistence.Repositories
{
    public class RepositoryExemplary : RepositoryBase<Exemplary, int>, IRepositoryExemplary
    {
        protected readonly LibraryContext _context;

        public RepositoryExemplary(LibraryContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddExemplary(Exemplary entidade)
        {
            await _context.Exemplary.AddAsync(entidade);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateExemplary(Exemplary entidade)
        {
            var itemToUpdate = await _context.Exemplary.FindAsync(entidade.Id);
            if (itemToUpdate != null)
            {
                itemToUpdate.Book_Id = entidade.Book_Id;
                itemToUpdate.Exemplary_Count = entidade.Exemplary_Count;
                _context.Exemplary.Update(itemToUpdate);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteExemplary(Exemplary entidade)
        {
            var e = await _context.Exemplary.FindAsync(entidade.Id);
            if (e != null)
            {
                _context.Exemplary.Remove(e);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Exemplary>> ListAllExemplary()
        {
            return await _context.Exemplary.ToListAsync();
        }

        public async Task<Exemplary> FindById(int id)
        {
            return await _context.Exemplary.FindAsync(id);
        }

        public async Task<IEnumerable<Exemplary>> GetAll()
        {
            return await _context.Exemplary.ToListAsync();
        }
    }
}