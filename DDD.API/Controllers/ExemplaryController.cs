using System.Collections.Generic;
using System.Threading.Tasks;
using DDD.Domain.Entities;
using DDD.Domain.Interfaces.Arguments;
using DDD.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace DDD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExemplaryController : ControllerBase, IRequest<Exemplary>
    {
        private readonly IServiceExemplary _service;

        public ExemplaryController(IServiceExemplary service)
        {
            _service = service;
        }

        // GET api/Exemplary/ListAll
        [HttpGet(Name = "GetExemplares")]
        [Route("ListAll")]
        public async Task<IEnumerable<Exemplary>> GetAll()
        {
            return await _service.ListAllExemplary();
        }

        // GET api/Exemplary/5
        [HttpGet("{id}")]
        public async Task<Exemplary> GetById(int id)
        {
            return await _service.GetExemplaryById(id);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Exemplary entidade)
        {
            if (entidade != null)
            {
                await _service.AddExemplary(entidade);
            }
            return CreatedAtRoute("GetExemplares", new { Controller = "Exemplary", id = entidade.Exemplary_Count }, entidade);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Exemplary entidade)
        {
            if (entidade != null)
            {
                await _service.EditExemplary(entidade);
            }
            return CreatedAtRoute("GetExemplares", new { Controller = "Exemplary", id = entidade.Exemplary_Count }, entidade);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] Exemplary entidade)
        {
            if (entidade.Id > 0)
            {
                await _service.DeleteExemplary(entidade);
            }
            return CreatedAtRoute("GetExemplares", new { Controller = "Exemplary", id = entidade.Exemplary_Count }, entidade);
        }

        
    }
}