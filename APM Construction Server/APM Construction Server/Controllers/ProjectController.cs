using APM_Construction_Server.Classes;
using APM_Construction_Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APM_Construction_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : Controller
    {
        private ProjectRepository _projectRepository = new();

        [HttpGet]
        public ActionResult<List<Project>> GetProjects()
        {
            var projects = _projectRepository.GetAll();
            return Ok(projects);
        }
        [HttpGet("{id}")]
        public ActionResult<Project> GetProject(int id)
        {
            var project = _projectRepository.GetById(id);
            if (project == null)
            {
                return NotFound();
            }
            return Ok(project);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Project projectData)
        {
            if (_projectRepository.FoundData(projectData))
            {
                _projectRepository.Post(projectData);
                return CreatedAtAction(nameof(GetProject), new { id = projectData.Id }, projectData);
            }
            return BadRequest("Client or Contractor is not exist.");
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Project projectData)
        {
            if (!_projectRepository.FoundData(projectData))
            {
                return NotFound();
            }

            _projectRepository.Put(id, projectData);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _projectRepository.Delete(id);
        }
    }
}
