using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using DDD.API.Controllers.Base;
using DDD.Domain.Arguments.Book;
using DDD.Domain.Interfaces.Services;
using DDD.Infra.Transactions;
using Microsoft.AspNetCore.Mvc;

namespace DDD.API.Controllers
{
    [Route("api/[controller]")]
    public class BookController : ControllerBaseDDD
    {
        private readonly IServiceBook _serviceBook;

        public BookController(IUnitOfWork unitOfWork,  IServiceBook serviceBook) : base(serviceBook)
        {
            _serviceBook = serviceBook;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2", "Eduardo" };
        }

        [Route("Adicionar")]
        [HttpPost]
        public async Task<HttpResponseMessage> AddBook(AddBookRequest request)
        {
            try
            {
                var response = _serviceBook.AddBook(request);

                return await ResponseAsync(response, _serviceBook);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }
        
        [Route("Atualizar")]
        [HttpPut]
        public async Task<HttpResponseMessage> UpdateBook(UpdateBookRequest request)
        {
            try
            {
                var response = _serviceBook.UpdateBook(request);

                return await ResponseAsync(response, _serviceBook);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [Route("Deletar")]
        [HttpDelete]
        public async Task<HttpResponseMessage> DeleteBook(DeleteBookRequest request)
        {
            try
            {
                var response = _serviceBook.DeleteBook(request);

                return await ResponseAsync(response, _serviceBook);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }     

        [Route("Listar")]
        [HttpGet]
        public async Task<HttpResponseMessage> ListAllBook()
        {
            try
            {
                var response = _serviceBook.ListAllBook();

                return await ResponseAsync(response, _serviceBook);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }  
        
    }
}
