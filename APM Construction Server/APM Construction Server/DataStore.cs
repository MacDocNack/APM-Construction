using APM_Construction_Server.Models;
using Task = APM_Construction_Server.Models.Task;

namespace APM_Construction_Server
{
    public class DataStore
    {
        private static DataStore _instance = new DataStore();
        public static DataStore Instance => _instance;

        public Dictionary<int, Client> Clients { get; set; }
        public Dictionary<int, Contractor> Contractors { get; set; }
        public Dictionary<int, Employee> Employees { get; set; }
        public Dictionary<int, FinanceOperation> FinanceOperations { get; set; }
        public Dictionary<int, Job> Jobs { get; set; }
        public Dictionary<int, Project> Projects { get; set; }
        public Dictionary<int, ProjectResource> ProjectResources { get; set; }
        public Dictionary<int, Resource> Resources { get; set; }
        public Dictionary<int, Task> Tasks { get; set; }
        public Dictionary<int, User> Users { get; set; }
    }
}
