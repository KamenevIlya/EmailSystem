using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmailSystem.Application.Models.Employees.Queries.GetEmployees;
using EmailSystem.Application.Models.Employees.Queries.ViewModels;

namespace EmailSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : BaseController
    {
        private readonly IMapper _mapper;

        public EmployeeController(IMapper mapper) => _mapper = mapper;

        /// <summary>
        /// Получить сотрудников
        /// </summary>
        /// <returns> Сотрудники </returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<EmployeesVm>> GetAllEmployees()
        {
            var query = new GetEmployeesQuery();
            var vm = await Mediator.Send(query);

            if (vm == null)
            {
                return StatusCode(500);
            }

            if (vm.Employees.Count == 0)
            {
                return NoContent();
            }

            return Ok(vm);
        }
    }
}