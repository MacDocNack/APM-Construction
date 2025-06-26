using APM_Construction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Media;
using Task = APM_Construction.Models.Task;


namespace APM_Construction
{
    public class ConnectToWeb
    {
        private static readonly HttpClient _client = new HttpClient();
        private static readonly string _baseUrl = "http://localhost:5117";

        #region GetAll method
        public async Task<IReadOnlyCollection<Client>> GetClientsAsync()
        {
            var res = await _client.GetAsync($"{_baseUrl}/api/Client");

            string json = await res.Content.ReadAsStringAsync();
            var client = JsonSerializer.Deserialize<List<Client>>(json);

            return client;
        }
        public async Task<IReadOnlyCollection<Contractor>> GetContractorsAsync()
        {
            var res = await _client.GetAsync($"{_baseUrl}/api/Contractor");

            string json = await res.Content.ReadAsStringAsync();
            var contractor = JsonSerializer.Deserialize<List<Contractor>>(json);

            return contractor;
        }
        public async Task<IReadOnlyCollection<Employee>> GetEmployeesAsync()
        {
            var res = await _client.GetAsync($"{_baseUrl}/api/Employee");

            string json = await res.Content.ReadAsStringAsync();
            var employee = JsonSerializer.Deserialize<List<Employee>>(json);

            return employee;
        }
        public async Task<IReadOnlyCollection<FinanceOperation>> GetFinanceOperationsAsync()
        {
            var res = await _client.GetAsync($"{_baseUrl}/api/FinanceOperation");

            string json = await res.Content.ReadAsStringAsync();
            var financeOperation = JsonSerializer.Deserialize<List<FinanceOperation>>(json);

            return financeOperation;
        }
        public async Task<IReadOnlyCollection<Job>> GetJobsAsync()
        {
            var res = await _client.GetAsync($"{_baseUrl}/api/Job");

            string json = await res.Content.ReadAsStringAsync();
            var job = JsonSerializer.Deserialize<List<Job>>(json);

            return job;
        }
        public async Task<IReadOnlyCollection<Project>> GetProjectsAsync()
        {
            var res = await _client.GetAsync($"{_baseUrl}/api/Project");

            string json = await res.Content.ReadAsStringAsync();
            var project = JsonSerializer.Deserialize<List<Project>>(json);

            return project;
        }
        public async Task<IReadOnlyCollection<ProjectResource>> GetProjectResourcesAsync()
        {
            var res = await _client.GetAsync($"{_baseUrl}/api/ProjectResource");

            string json = await res.Content.ReadAsStringAsync();
            var projectResource = JsonSerializer.Deserialize<List<ProjectResource>>(json);

            return projectResource;
        }
        public async Task<IReadOnlyCollection<Resource>> GetResourcesAsync()
        {
            var res = await _client.GetAsync($"{_baseUrl}/api/Resource");

            string json = await res.Content.ReadAsStringAsync();
            var resource = JsonSerializer.Deserialize<List<Resource>>(json);

            return resource;
        }
        public async Task<IReadOnlyCollection<Task>> GetTasksAsync()
        {
            var res = await _client.GetAsync($"{_baseUrl}/api/Task");

            string json = await res.Content.ReadAsStringAsync();
            var task = JsonSerializer.Deserialize<List<Task>>(json);

            return task;
        }
        public async Task<IReadOnlyCollection<User>> GetUsersAsync()
        {
            var res = await _client.GetAsync($"{_baseUrl}/api/User");

            string json = await res.Content.ReadAsStringAsync();
            var user = JsonSerializer.Deserialize<List<User>>(json);

            return user;
        }
        #endregion
        #region GetByID method
        public async Task<Client> GetClientById(int id)
        {
            var res = await _client.GetAsync($"{_baseUrl}/api/Client/{id}");

            string json = await res.Content.ReadAsStringAsync();
            var client = JsonSerializer.Deserialize<Client>(json);

            return client;
        }
        public async Task<Contractor> GetContractorById(int id)
        {
            var res = await _client.GetAsync($"{_baseUrl}/api/Contractor/{id}");

            string json = await res.Content.ReadAsStringAsync();
            var contractor = JsonSerializer.Deserialize<Contractor>(json);

            return contractor;
        }
        public async Task<Employee> GetEmployeeById(int id)
        {
            var res = await _client.GetAsync($"{_baseUrl}/api/Employee/{id}");

            string json = await res.Content.ReadAsStringAsync();
            var employee = JsonSerializer.Deserialize<Employee>(json);

            return employee;
        }
        public async Task<FinanceOperation> GetFinanceOperationById(int id)
        {
            var res = await _client.GetAsync($"{_baseUrl}/api/FinanceOperation/{id}");

            string json = await res.Content.ReadAsStringAsync();
            var financeOperation = JsonSerializer.Deserialize<FinanceOperation>(json);

            return financeOperation;
        }
        public async Task<Job> GetJobById(int id)
        {
            var res = await _client.GetAsync($"{_baseUrl}/api/Job/{id}");

            string json = await res.Content.ReadAsStringAsync();
            var job = JsonSerializer.Deserialize<Job>(json);

            return job;
        }
        public async Task<Project> GetProjectById(int id)
        {
            var res = await _client.GetAsync($"{_baseUrl}/api/Project/{id}");

            string json = await res.Content.ReadAsStringAsync();
            var project = JsonSerializer.Deserialize<Project>(json);

            return project;
        }
        public async Task<ProjectResource> GetProjectResourceById(int id)
        {
            var res = await _client.GetAsync($"{_baseUrl}/api/ProjectResource/{id}");

            string json = await res.Content.ReadAsStringAsync();
            var projectResource = JsonSerializer.Deserialize<ProjectResource>(json);

            return projectResource;
        }
        public async Task<Resource> GetResourceById(int id)
        {
            var res = await _client.GetAsync($"{_baseUrl}/api/Resource/{id}");

            string json = await res.Content.ReadAsStringAsync();
            var resource = JsonSerializer.Deserialize<Resource>(json);

            return resource;
        }
        public async Task<Task> GetTaskById(int id)
        {
            var res = await _client.GetAsync($"{_baseUrl}/api/Task/{id}");

            string json = await res.Content.ReadAsStringAsync();
            var task = JsonSerializer.Deserialize<Task>(json);

            return task;
        }
        #endregion
        #region POST method
        public async void ClientPost(Client client)
        {
            await _client.PostAsJsonAsync($"{_baseUrl}/api/Client", client);
        }
        public async void UserPost(User user)
        {
            await _client.PostAsJsonAsync($"{_baseUrl}/api/User", user);
        }
        public async void ContractorPost(Contractor contractor)
        {
            await _client.PostAsJsonAsync($"{_baseUrl}/api/Contractor", contractor);
        }
        public async void EmployeePost(Employee employee)
        {
            await _client.PostAsJsonAsync($"{_baseUrl}/api/Employee", employee);
        }
        public async void FinanceOperationPost(FinanceOperation financeOperation)
        {
            await _client.PostAsJsonAsync($"{_baseUrl}/api/FinanceOperation", financeOperation);
        }
        public async void JobPost(Job job)
        {
            await _client.PostAsJsonAsync($"{_baseUrl}/api/Job", job);
        }
        public async void ProjectPost(Project project)
        {
            await _client.PostAsJsonAsync($"{_baseUrl}/api/Project", project);
        }
        public async void ProjectResourcePost(ProjectResource projectResource)
        {
            await _client.PostAsJsonAsync($"{_baseUrl}/api/ProjectResource", projectResource);
        }
        public async void ResourcePost(Resource resource)
        {
            await _client.PostAsJsonAsync($"{_baseUrl}/api/Resource", resource);
        }
        public async void TaskPost(Task task)
        {
            await _client.PostAsJsonAsync($"{_baseUrl}/api/Task", task);
        }
        #endregion
        #region PUT method
        public async void ClientPut(Client client)
        {
            await _client.PutAsJsonAsync($"{_baseUrl}/api/Client/{client.Id}", client);
        }
        public async void UserPut(User user)
        {
            await _client.PutAsJsonAsync($"{_baseUrl}/api/User/{user.Id}", user);
        }
        public async void ContractorPut(Contractor contractor)
        {
            await _client.PutAsJsonAsync($"{_baseUrl}/api/Contractor/{contractor.Id}", contractor);
        }
        public async void EmployeePut(Employee employee)
        {
            await _client.PutAsJsonAsync($"{_baseUrl}/api/Employee/{employee.Id}", employee);
        }
        public async void FinanceOperationPut(FinanceOperation financeOperation)
        {
            await _client.PutAsJsonAsync($"{_baseUrl}/api/FinanceOperation/{financeOperation.Id}", financeOperation);
        }
        public async void JobPut(Job job)
        {
            await _client.PutAsJsonAsync($"{_baseUrl}/api/Job/{job.Id}", job);
        }
        public async void ProjectPut(Project project)
        {
            await _client.PutAsJsonAsync($"{_baseUrl}/api/Project/{project.Id}", project);
        }
        public async void ProjectResourcePut(ProjectResource projectResource)
        {
            await _client.PutAsJsonAsync($"{_baseUrl}/api/ProjectResource/{projectResource.Id}", projectResource);
        }
        public async void ResourcePut(Resource resource)
        {
            await _client.PutAsJsonAsync($"{_baseUrl}/api/Resource/{resource.Id}", resource);
        }
        public async void TaskPut(Task task)
        {
            await _client.PutAsJsonAsync($"{_baseUrl}/api/Task/{task.Id}", task);
        }
        #endregion
        #region DELETE method
        public async void ClientDelete(Client client)
        {
            await _client.DeleteAsync($"{_baseUrl}/api/Client/{client.Id}");
        }
        public async void UserDelete(User user)
        {
            await _client.DeleteAsync($"{_baseUrl}/api/User/{user.Id}");
        }
        public async void ContractorDelete(Contractor contractor)
        {
            await _client.DeleteAsync($"{_baseUrl}/api/Contractor/{contractor.Id}");
        }
        public async void EmployeeDelete(Employee employee)
        {
            await _client.DeleteAsync($"{_baseUrl}/api/Employee/{employee.Id}");
        }
        public async void FinanceOperationDelete(FinanceOperation financeOperation)
        {
            await _client.DeleteAsync($"{_baseUrl}/api/FinanceOperation/{financeOperation.Id}");
        }
        public async void JobDelete(Job job)
        {
            await _client.DeleteAsync($"{_baseUrl}/api/Job/{job.Id}");
        }
        public async void ProjectDelete(Project project)
        {
            await _client.DeleteAsync($"{_baseUrl}/api/Project/{project.Id}");
        }
        public async void ProjectResourceDelete(ProjectResource projectResource)
        {
            await _client.DeleteAsync($"{_baseUrl}/api/ProjectResource/{projectResource.Id}");
        }
        public async void ResourceDelete(Resource resource)
        {
            await _client.DeleteAsync($"{_baseUrl}/api/Resource/{resource.Id}");
        }
        public async void TaskDelete(Task task)
        {
            await _client.DeleteAsync($"{_baseUrl}/api/Task/{task.Id}");
        }
        #endregion
    }
}
