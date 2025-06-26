using APM_Construction_Server.Classes;
using APM_Construction_Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APM_Construction_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private UserRepository _userRepository = new();

        [HttpGet]
        public List<User> GetClients()
        {
            return _userRepository.GetAll();
        }
        [HttpGet("{id}")]
        public User GetClient(int id)
        {
            return _userRepository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] User userData)
        {
            _userRepository.Post(userData);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User clientData)
        {
            _userRepository.Put(id, clientData);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _userRepository.Delete(id);
        }
    }
}
