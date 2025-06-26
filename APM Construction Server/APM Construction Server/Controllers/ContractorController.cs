using APM_Construction_Server.Classes;
using APM_Construction_Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APM_Construction_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractorController : Controller
    {
        private ContractorRepository _contractorRepository = new();

        [HttpGet]
        public List<Contractor> GetContractors()
        {
            return _contractorRepository.GetAll();
        }
        [HttpGet("{id}")]
        public Contractor GetContractor(int id)
        {
            return _contractorRepository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Contractor contractorData)
        {
            _contractorRepository.Post(contractorData);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Contractor contractorData)
        {
            _contractorRepository.Put(id, contractorData);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _contractorRepository.Delete(id);
        }
    }
}
