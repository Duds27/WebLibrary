using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DDD.Domain.Entities;
using DDD.Domain.Interfaces.Repositories;
using DDD.Infra.Persistence.Repositories.Base;
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
    }
}