using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDD.Domain.Entities;
using DDD.Domain.Interfaces.Arguments;
using DDD.Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DDD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public IRepositoryBook _repository { get; set; }
        
        public ValuesController(IRepositoryBook repository)
        {
            _repository = repository;
        }        

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/ListaBooks
        [HttpGet(Name = "GetBooks")]
        [Route("ListaBooks")]
        public async Task<IActionResult> GetLista()
        {
            var bookList =  await _repository.GetAll();
            return Ok(bookList);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Book item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            await _repository.AddBook(item);
            return CreatedAtRoute("GetBooks", new { Controller = "Values", id = item.Book_Description }, item);
        }

        
    }
}
