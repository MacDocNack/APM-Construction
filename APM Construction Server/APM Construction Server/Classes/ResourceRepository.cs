using APM_Construction_Server.Models;

namespace APM_Construction_Server.Classes
{
    public class ResourceRepository
    {
        public Resource GetById(int id)
        {
            DataStore.Instance.Resources.TryGetValue(id, out var resource);

            return resource;
        }

        public List<Resource> GetAll()
        {
            return DataStore.Instance.Resources.Values.ToList();
        }

        public void Post(Resource resource)
        {
            DataStore.Instance.Resources.Add(resource.Id, resource);
        }

        public void Put(int id, Resource resource)
        {
            DataStore.Instance.Resources[resource.Id] = resource;
        }

        public void Delete(int id)
        {
            DataStore.Instance.Resources.Remove(id);
        }
    }
}
