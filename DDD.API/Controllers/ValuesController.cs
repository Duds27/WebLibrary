using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDD.Domain.Arguments.Book;
using DDD.Domain.Entities;
using DDD.Domain.Interfaces.Arguments;
using DDD.Domain.Interfaces.Repositories;
using DDD.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace DDD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public IRepositoryBook _repository { get; set; }
        private readonly IServiceBook _service;
        
        // public ValuesController(IRepositoryBook repository)
        // {
        //     _repository = repository;
        // }

        public ValuesController(IServiceBook service, IRepositoryBook repository)
        {
            _service = service;
            _repository = repository;
        }

        // GET api/values
        // [HttpGet("test/{id}")]
        // public async Task<Book> Get(int id)
        // {
        //     return await _repository.Find(id);
        // }

        // GET api/values/ListaBooks
        [HttpGet(Name = "GetBooks")]
        [Route("ListaBooks")]
        public async Task<IActionResult> GetLista()
        {
            var bookList =  await _repository.ListAllBook();
            return Ok(bookList);
            //return null;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Book item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            await _repository.AddBook(item);
            //await _service.AddBook(item);
            return CreatedAtRoute("GetBooks", new { Controller = "Values", id = item.Book_Description }, item);
        }

        [HttpPost]
        [Route("test")]
        public ActionResult<Book> Create2([FromBody] Book item)
        {
            return item;
        }

        [HttpPut]
        [Route("TestPut")]
        public async Task TestPut([FromBody] Book book)
        {
            await _repository.UpdateBook(book);
        }

        
    }
}
