using APM_Construction_Server.Models;

namespace APM_Construction_Server.Interfaces
{
    public interface IProjectRepository
    {
        List<Project> GetAll();
        Project GetById(int id);
        void Post(Project project);
        void Put(int id, Project project);
        void Delete(int id);
    }
}
