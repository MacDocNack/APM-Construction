using APM_Construction_Server.Models;

namespace APM_Construction_Server.Interfaces
{
    public interface IResourceRepository
    {
        List<Resource> GetAll();
        Resource GetById(int id);
        void Post(Resource resource);
        void Put(int id, Resource resource);
        void Delete(int id);
    }
}
