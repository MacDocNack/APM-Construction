using APM_Construction_Server.Classes;
using APM_Construction_Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APM_Construction_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private EmployeeRepository _employeeRepository = new();

        [HttpGet]
        public List<Employee> GetEmployees()
        {
            return _employeeRepository.GetAll();
        }
        [HttpGet("{id}")]
        public Employee GetEmployee(int id)
        {
            return _employeeRepository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Employee employeeData)
        {
            _employeeRepository.Post(employeeData);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee employeeData)
        {
            _employeeRepository.Put(id, employeeData);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _employeeRepository.Delete(id);
        }
    }
}
