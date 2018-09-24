using System.Collections.Generic;
using System.Threading.Tasks;
using DDD.Domain.Arguments;
using DDD.Domain.Arguments.Book;
using DDD.Domain.Entities.Base;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Domain.Interfaces.Arguments
{
    public interface IRequest<TEntidade>
        where TEntidade: EntityBase
    {
        Task<IEnumerable<TEntidade>> GetAll();
        Task<TEntidade> GetById(int id);
        Task<IActionResult> Post(TEntidade entidade);
        Task<IActionResult> Put(TEntidade entidade);
        Task<IActionResult> Delete();
    }
}