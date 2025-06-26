using APM_Construction_Server.Classes;
using APM_Construction_Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APM_Construction_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectResourceController : Controller
    {
        private ProjectResourceRepository _projectResourceRepository = new();

        [HttpGet]
        public List<ProjectResource> GetProjectResources()
        {
            return _projectResourceRepository.GetAll();
        }
        [HttpGet("{id}")]
        public ProjectResource GetProjectResource(int id)
        {
            return _projectResourceRepository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] ProjectResource projectResourceData)
        {
            _projectResourceRepository.Post(projectResourceData);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ProjectResource projectResourceData)
        {
            _projectResourceRepository.Put(id, projectResourceData);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _projectResourceRepository.Delete(id);
        }
    }
}
