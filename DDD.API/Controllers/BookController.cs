using System.Collections.Generic;
using System.Threading.Tasks;
using DDD.Domain.Entities;
using DDD.Domain.Entities.Base;
using DDD.Domain.Interfaces.Arguments;
using DDD.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace DDD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase, IRequest<Book>
    {
        private readonly IServiceBook _service;

        public BookController(IServiceBook service)
        {
            _service = service;
        }

        // GET api/Book/ListAll
        [HttpGet(Name = "GetLivros")]
        [Route("ListAll")]
        public async Task<IEnumerable<Book>> GetAll()
        {
            return await _service.ListAllBook();
        }

        // GET api/Book/5
        [HttpGet("{id}")]
        public async Task<Book> GetById(int id)
        {
            return await _service.GetBookById(id);
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Book entidade)
        {
            if (entidade != null)
            {
                await _service.AddBook(entidade);
            }
            return CreatedAtRoute("GetLivros", new { Controller = "Book", id = entidade.Book_Description }, entidade);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Book entidade)
        {
            if (entidade != null)
            {
                await _service.EditBook(entidade);
            }
            return CreatedAtRoute("GetLivros", new { Controller = "Book", id = entidade.Book_Description }, entidade);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] Book entidade)
        {
            if (entidade.Id > 0)
            {
                await _service.DeleteBook(entidade);
            }
            return CreatedAtRoute("GetLivros", new { Controller = "Book", id = entidade.Book_Description }, entidade);            
        }

    }
}