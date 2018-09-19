using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using DDD.API.Controllers.Base;
using DDD.Domain.Arguments.Book;
using DDD.Domain.Entities;
using DDD.Domain.Interfaces.Services;
using DDD.Infra.Transactions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DDD.API.Controllers
{
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IServiceBook _serviceBook;

        // public BookController(IUnitOfWork unitOfWork,  IServiceBook serviceBook) : base(unitOfWork)
        public BookController(IServiceBook serviceBook)
        {
            _serviceBook = serviceBook;
        }

        // GET api/values
        [HttpGet]
        [AllowAnonymous]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2", "Eduardo" };
        }

        [Route("Adicionar")]
        [HttpPost]
        // public async Task<HttpResponseMessage> AddBook(AddBookRequest request)
        public async Task<AddBookResponse> AddBook(AddBookRequest request)
        {
            try
            {
                AddBookResponse response = _serviceBook.AddBook(request);

                // return await ResponseAsync(response, _serviceBook);
                return await (AddBookResponse0 responses;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        
       /* [Route("Atualizar")]
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
        }  */
        
    }
}
