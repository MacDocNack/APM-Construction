using APM_Construction_Server.Classes;
using APM_Construction_Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task = APM_Construction_Server.Models.Task;

namespace APM_Construction_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : Controller
    {
        private TaskRepository _taskRepository = new();

        [HttpGet]
        public List<Task> GetTasks()
        {
            return _taskRepository.GetAll();
        }
        [HttpGet("{id}")]
        public Task GetTask(int id)
        {
            return _taskRepository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Task taskData)
        {
            _taskRepository.Post(taskData);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Task taskData)
        {
            _taskRepository.Put(id, taskData);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _taskRepository.Delete(id);
        }
    }
}
