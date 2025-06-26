using APM_Construction_Server.Models;
using Task = APM_Construction_Server.Models.Task;

namespace APM_Construction_Server.Interfaces
{
    public interface ITaskRepository
    {
        List<Task> GetAll();
        Task GetById(int id);
        void Post(Task task);
        void Put(int id, Task task);
        void Delete(int id);
    }
}
