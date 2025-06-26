using APM_Construction_Server.Models;

namespace APM_Construction_Server.Classes
{
    public class JobRepository
    {
        public Job GetById(int id)
        {
            DataStore.Instance.Jobs.TryGetValue(id, out var job);

            return job;
        }

        public List<Job> GetAll()
        {
            return DataStore.Instance.Jobs.Values.ToList();
        }

        public void Post(Job job)
        {
            DataStore.Instance.Jobs.Add(job.Id, job);
        }

        public void Put(int id, Job job)
        {
            DataStore.Instance.Jobs[job.Id] = job;
        }

        public void Delete(int id)
        {
            DataStore.Instance.Jobs.Remove(id);
        }

        private bool FoundData(Job job)
        {
            if (!DataStore.Instance.Tasks.TryGetValue(job.IdTask, out var task))
                return false;
            if (!DataStore.Instance.Employees.TryGetValue(job.IdEmployee, out var employee))
                return false;
            return true;
        }
    }
}
