using APM_Construction_Server.Models;
using Task = APM_Construction_Server.Models.Task;

namespace APM_Construction_Server.Classes
{
    public class TaskRepository
    {
        public Task GetById(int id)
        {
            DataStore.Instance.Tasks.TryGetValue(id, out var taskData);

            return taskData;
        }

        public List<Task> GetAll()
        {
            return DataStore.Instance.Tasks.Values.ToList();
        }

        public void Post(Task taskData)
        {
            if (FoundData(taskData))
                DataStore.Instance.Tasks.Add(taskData.Id, taskData);
        }

        public void Put(int id, Task taskData)
        {
            if (FoundData(taskData))
                DataStore.Instance.Tasks[taskData.Id] = taskData;
        }

        public void Delete(int id)
        {
            DataStore.Instance.Tasks.Remove(id);
        }

        private bool FoundData(Task taskData)
        {
            if (!DataStore.Instance.Projects.TryGetValue(taskData.IdProject, out var project))
                return false;
            return true;
        }
    }
}
