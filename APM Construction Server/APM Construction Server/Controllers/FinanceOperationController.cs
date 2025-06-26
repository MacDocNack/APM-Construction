using APM_Construction_Server.Classes;
using APM_Construction_Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APM_Construction_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinanceOperationController : Controller
    {
        private FinanceOperationRepository _financeOperationRepository = new();

        [HttpGet]
        public List<FinanceOperation> GetFinanceOperations()
        {
            return _financeOperationRepository.GetAll();
        }
        [HttpGet("{id}")]
        public FinanceOperation GetFinanceOperation(int id)
        {
            return _financeOperationRepository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] FinanceOperation financeOperationData)
        {
            _financeOperationRepository.Post(financeOperationData);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] FinanceOperation financeOperationData)
        {
            _financeOperationRepository.Put(id, financeOperationData);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _financeOperationRepository.Delete(id);
        }
    }
}
