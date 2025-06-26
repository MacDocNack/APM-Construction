using APM_Construction_Server.Classes;
using APM_Construction_Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APM_Construction_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : Controller
    {
        private ClientRepository _clientRepository = new();

        [HttpGet]
        public List<Client> GetClients()
        {
            return _clientRepository.GetAll();
        }
        [HttpGet("{id}")]
        public Client GetClient(int id)
        {
            return _clientRepository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Client clientData)
        {
            _clientRepository.Post(clientData);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Client clientData)
        {
            _clientRepository.Put(id, clientData);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _clientRepository.Delete(id);
        }
    }
}
