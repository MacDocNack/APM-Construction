using APM_Construction_Server.Models;

namespace APM_Construction_Server.Interfaces
{
    public interface IProjectResourceRepository
    {
        List<ProjectResource> GetAll();
        ProjectResource GetById(int id);
        void Post(ProjectResource projectResource);
        void Put(int id, ProjectResource projectResource);
        void Delete(int id);
    }
}
