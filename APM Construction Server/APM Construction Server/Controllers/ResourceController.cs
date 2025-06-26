using APM_Construction_Server.Classes;
using APM_Construction_Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APM_Construction_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourceController : Controller
    {
        private ResourceRepository _resourceRepository = new();

        [HttpGet]
        public List<Resource> GetResources()
        {
            return _resourceRepository.GetAll();
        }
        [HttpGet("{id}")]
        public Resource GetResource(int id)
        {
            return _resourceRepository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Resource resourceData)
        {
            _resourceRepository.Post(resourceData);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Resource resourceData)
        {
            _resourceRepository.Put(id, resourceData);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _resourceRepository.Delete(id);
        }
    }
}
