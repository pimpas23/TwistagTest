using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TwistagTest.Business.Interfaces;
using TwistagTest.Shared.Models;

namespace TwistagTest.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> Get()
        {
            return Ok(await _employeeService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> Get(Guid id)
        {
            var employee = await _employeeService.Get(id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        [HttpPost]
        public async Task<ActionResult<Employee>> Post(Employee employee)
        {
            await _employeeService.Add(employee);

            return CreatedAtAction("Get", new { id = employee.Id }, employee);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, Employee employee)
        {
            if (id != employee.Id)
            {
                return BadRequest();
            }

            await _employeeService.Update(employee);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _employeeService.Delete(id);

            return NoContent();
        }
    }
}
