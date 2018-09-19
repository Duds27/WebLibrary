

using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using DDD.Domain.Interfaces.Services.Base;
using DDD.Infra.Transactions;
using Microsoft.AspNetCore.Mvc;

namespace DDD.API.Controllers.Base
{
    public class ControllerBaseDDD : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        private IServiceBase _serviceBase;
        
        // public ControllerBaseDDD(IUnitOfWork unitOfWork)
        public ControllerBaseDDD(IServiceBase serviceBase)
        {
            // _unitOfWork = unitOfWork;
            _serviceBase = serviceBase;
        }

        public async Task<HttpResponseMessage> ResponseAsync(object result, IServiceBase serviceBase)
        {
            _serviceBase = serviceBase;

            try
                {
                // _unitOfWork.Commit();

                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                // Aqui devo logar o erro
                return Request.CreateResponse(HttpStatusCode.Conflict, $"Houve um problema interno com o servidor. Entre em contato com o Administrador do sistema caso o problema persista. Erro interno: {ex.Message}");
            }

        }

        public async Task<HttpResponseMessage> ResponseExceptionAsync(Exception ex)
        {
            return Request.CreateResponse(HttpStatusCode.InternalServerError, new { errors = ex.Message, exception = ex.ToString() });
        }

        protected void Dispose(bool disposing)
        {
            //Realiza o dispose no serviço para que possa ser zerada as notificações
            if (_serviceBase != null)
            {
                _serviceBase.Dispose();
            }

            Dispose(disposing);
        }
    }
}