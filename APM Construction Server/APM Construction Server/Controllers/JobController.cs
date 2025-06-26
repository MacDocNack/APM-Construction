using APM_Construction_Server.Classes;
using APM_Construction_Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APM_Construction_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : Controller
    {
        private JobRepository _jobRepository = new();

        [HttpGet]
        public List<Job> GetJobs()
        {
            return _jobRepository.GetAll();
        }
        [HttpGet("{id}")]
        public Job GetJob(int id)
        {
            return _jobRepository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Job jobData)
        {
            _jobRepository.Post(jobData);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Job jobData)
        {
            _jobRepository.Put(id, jobData);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _jobRepository.Delete(id);
        }
    }
}
