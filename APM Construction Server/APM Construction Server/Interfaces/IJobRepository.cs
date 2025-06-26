using APM_Construction_Server.Models;

namespace APM_Construction_Server.Interfaces
{
    public interface IJobRepository
    {
        List<Job> GetAll();
        Job GetById(int id);
        void Post(Job job);
        void Put(int id, Job job);
        void Delete(int id);
    }
}
