using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Domain.Interfaces.Arguments
{
    public interface IRequest
    {
        Task<IActionResult> GetById();
        Task<IActionResult> GetAll();
        Task<IActionResult> Post();
        Task<IActionResult> Put();
        Task<IActionResult> Delete();
    }
}