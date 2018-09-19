using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Collections.Generic;
using System.Linq;
using DDD.API.Controllers.Base;
using DDD.Domain.Arguments.Book;
using DDD.Domain.Interfaces.Services;
using DDD.Infra.Transactions;
using Microsoft.AspNetCore.Mvc;
using DDD.Domain.Arguments.Exemplary;

namespace DDD.API.Controllers
{
    [System.Web.Http.Route("api/[controller]")]
    public class ExemplaryController : ControllerBaseDDD
    {
        private readonly IServiceExemplary _serviceExemplary;

        // public ExemplaryController(IUnitOfWork unitOfWork,  IServiceExemplary serviceExemplary) : base(unitOfWork)
        public ExemplaryController(IServiceExemplary serviceExemplary) : base(serviceExemplary)
        {
            // _serviceExemplary = serviceExemplary;
        }


        [System.Web.Http.Route("Adicionar")]
        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> AddExemplary(AddExemplaryRequest request)
        {
            try
            {
                var response = _serviceExemplary.AddExemplary(request);

                return await ResponseAsync(response, _serviceExemplary);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }
        
        [System.Web.Http.Route("Listar")]
        [System.Web.Http.HttpGet]
        public async Task<HttpResponseMessage> GetExemplaryCount(GetExemplaryRequest request)
        {
            try
            {
                var response = _serviceExemplary.GetExemplaryCount(request);

                return await ResponseAsync(response, _serviceExemplary);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }  
        
    }
}
