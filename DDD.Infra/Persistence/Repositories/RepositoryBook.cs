

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
    public class RepositoryBook : RepositoryBase<Book, int>, IRepositoryBook
    {
        protected readonly LibraryContext _context;

        public RepositoryBook(LibraryContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddBook(Book entidade)
        {
            await _context.Book.AddAsync(entidade);
            await _context.SaveChangesAsync();
        }





        public async Task UpdateBook(Book entidade)
        {
            var itemToUpdate = await _context.Book.FindAsync(entidade.Id);
            if (itemToUpdate != null)
            {
                itemToUpdate.Book_Title = entidade.Book_Title;
                itemToUpdate.Book_Description = entidade.Book_Description;
                itemToUpdate.Book_Author = entidade.Book_Author;
                itemToUpdate.Book_Publishing_Company = entidade.Book_Publishing_Company;
                itemToUpdate.Book_Price = entidade.Book_Price;
                _context.Book.Update(itemToUpdate); 
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteBook(Book entidade)
        {
            var b = await _context.Book.FindAsync(entidade.Id);
            if (b != null)
            {
                _context.Book.Remove(b);
                await _context.SaveChangesAsync();
            }
        }
        
        public async Task<IEnumerable<Book>> ListAllBook()
        {
            return await _context.Book.ToListAsync();
        }

        

        public async Task<Book> FindById(int id)
        {
            return await _context.Book.FindAsync(id);
        }        

         public async Task<IEnumerable<Book>> GetAll()
        {
            return await _context.Book.ToListAsync();
        }
        
    }
}