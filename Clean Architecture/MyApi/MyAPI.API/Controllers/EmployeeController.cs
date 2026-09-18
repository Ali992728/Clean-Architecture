using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyAPI.Application.Commands.EmployeeCommands;
using MyAPI.Application.Queries.EmployeeQueries;
using MyAPI.Core.DTO;

namespace MyAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(IMediator mediator) : ControllerBase
    {
        [HttpGet("GetAllEmployees")]
        public async Task<IActionResult> GetAllEmployees()
        {
            var result = await mediator.Send(new GetAllEmployeeQuery());
            return Ok(result);
        }

        [HttpPost("AddEmployee")]
        public async Task<IActionResult> AddEmployee([FromBody]EmployeeDto employee)
        {
            var result = await mediator.Send(new AddEmployeesCommand(employee));
            return Ok(result);
        }


        [HttpDelete("DeleteEmployee/{id}")]
        public async Task<IActionResult> DeleteEmployee([FromRoute]int id)
        {
            var result = await mediator.Send(new DeleteEmployeeCommand(id));
            return Ok(result);
        }
    }
}
