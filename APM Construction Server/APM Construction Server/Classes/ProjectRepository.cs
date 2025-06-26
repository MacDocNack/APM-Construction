using APM_Construction_Server.Models;

namespace APM_Construction_Server.Classes
{
    public class ProjectRepository
    {
        public Project GetById(int id)
        {
            DataStore.Instance.Projects.TryGetValue(id, out var projectData);

            return projectData;
        }

        public List<Project> GetAll()
        {
            return DataStore.Instance.Projects.Values.ToList();
        }

        public void Post(Project projectData)
        {
            DataStore.Instance.Projects.Add(projectData.Id, projectData);
        }

        public void Put(int id, Project projectData)
        {
            DataStore.Instance.Projects[projectData.Id] = projectData;
        }

        public void Delete(int id)
        {
            DataStore.Instance.Projects.Remove(id);
        }

        public bool FoundData(Project projectData)
        {
            if (!DataStore.Instance.Clients.TryGetValue(projectData.IdClient, out var client))
                return false;
            if (!DataStore.Instance.Contractors.TryGetValue(projectData.IdContractor, out var contractor))
                return false;
            return true;
        }
    }
}
