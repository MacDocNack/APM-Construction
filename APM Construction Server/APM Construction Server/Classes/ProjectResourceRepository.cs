using APM_Construction_Server.Models;

namespace APM_Construction_Server.Classes
{
    public class ProjectResourceRepository
    {
        public ProjectResource GetById(int id)
        {
            DataStore.Instance.ProjectResources.TryGetValue(id, out var projectResourceData);

            return projectResourceData;
        }

        public List<ProjectResource> GetAll()
        {
            return DataStore.Instance.ProjectResources.Values.ToList();
        }

        public void Post(ProjectResource projectResourceData)
        {
            DataStore.Instance.ProjectResources.Add(projectResourceData.Id, projectResourceData);
        }

        public void Put(int id, ProjectResource projectResourceData)
        {
            DataStore.Instance.ProjectResources[projectResourceData.Id] = projectResourceData;
        }

        public void Delete(int id)
        {
            DataStore.Instance.ProjectResources.Remove(id);
        }

        private bool FoundData(ProjectResource projectResourceData)
        {
            if (!DataStore.Instance.Projects.TryGetValue(projectResourceData.IdProject, out var project))
                return false;
            if (!DataStore.Instance.Resources.TryGetValue(projectResourceData.IdResource, out var resource))
                return false;
            return true;
        }
    }
}
