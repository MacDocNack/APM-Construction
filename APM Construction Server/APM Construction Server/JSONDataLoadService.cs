using APM_Construction_Server.Models;
using System.Text.Json;
using Task = APM_Construction_Server.Models.Task;

namespace APM_Construction_Server
{
    public class JSONDataLoadService
    {
        private static JSONDataLoadService _instance = new JSONDataLoadService();
        public static JSONDataLoadService Instance
        {
            get
            {
                _instance ??= new JSONDataLoadService();
                return _instance;
            }
        }

        public JSONDataLoadService()
        {
            _instance = this;
        }

        // Later can use AppData folder to JSON objects
        private static string solutionDirectory = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.FullName;
        private static string _projectPath = Path.Combine(solutionDirectory, "Data", "projects.json");
        private static string _resourcePath = Path.Combine(solutionDirectory, "Data", "resources.json");
        private static string _clientPath = Path.Combine(solutionDirectory, "Data", "clients.json");
        private static string _contractorPath = Path.Combine(solutionDirectory, "Data", "contractors.json");
        private static string _taskPath = Path.Combine(solutionDirectory, "Data", "tasks.json");
        private static string _employeePath = Path.Combine(solutionDirectory, "Data", "employees.json");
        private static string _projectResourcePath = Path.Combine(solutionDirectory, "Data", "projectresources.json");
        private static string _jobPath = Path.Combine(solutionDirectory, "Data", "jobs.json");
        private static string _financeOperationPath = Path.Combine(solutionDirectory, "Data", "financeoperations.json");
        private static string _userPath = Path.Combine(solutionDirectory, "Data", "users.json");


        public void LoadData()
        {
            #region Load Project
            try
            {
                var json = File.ReadAllText(_projectPath);
                var projects = JsonSerializer.Deserialize<List<Project>>(json);

                if (projects != null)
                {
                    int i = 0;
                    foreach (var project in projects)
                    {
                        DataStore.Instance.Projects.Add(i, project);
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при загрузке данных: {ex.Message}");
            }
            #endregion
            #region Load Resource
            try
            {
                var json = File.ReadAllText(_resourcePath);
                var resources = JsonSerializer.Deserialize<List<Resource>>(json);

                if (resources != null)
                {
                    int i = 0;
                    foreach (var resource in resources)
                    {
                        DataStore.Instance.Resources.Add(i, resource);
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при загрузке данных: {ex.Message}");
            }
            #endregion
            #region Load Client
            try
            {
                var json = File.ReadAllText(_clientPath);
                var clients = JsonSerializer.Deserialize<List<Client>>(json);

                if (clients != null)
                {
                    int i = 0;
                    foreach (var client in clients)
                    {
                        DataStore.Instance.Clients.Add(i, client);
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при загрузке данных: {ex.Message}");
            }
            #endregion
            #region Load Contractor
            try
            {
                var json = File.ReadAllText(_contractorPath);
                var contractors = JsonSerializer.Deserialize<List<Contractor>>(json);

                if (contractors != null)
                {
                    int i = 0;
                    foreach (var contractor in contractors)
                    {
                        DataStore.Instance.Contractors.Add(i, contractor);
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при загрузке данных: {ex.Message}");
            }
            #endregion
            #region Load Task
            try
            {
                var json = File.ReadAllText(_taskPath);
                var tasks = JsonSerializer.Deserialize<List<Task>>(json);

                if (tasks != null)
                {
                    int i = 0;
                    foreach (var task in tasks)
                    {
                        DataStore.Instance.Tasks.Add(i, task);
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при загрузке данных: {ex.Message}");
            }
            #endregion
            #region Load Employee
            try
            {
                var json = File.ReadAllText(_employeePath);
                var employees = JsonSerializer.Deserialize<List<Employee>>(json);

                if (employees != null)
                {
                    int i = 0;
                    foreach (var employee in employees)
                    {
                        DataStore.Instance.Employees.Add(i, employee);
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при загрузке данных: {ex.Message}");
            }
            #endregion
            #region Load Project Resources
            try
            {
                var json = File.ReadAllText(_projectResourcePath);
                var projectResources = JsonSerializer.Deserialize<List<ProjectResource>>(json);

                if (projectResources != null)
                {
                    int i = 0;
                    foreach (var projectResource in projectResources)
                    {
                        DataStore.Instance.ProjectResources.Add(i, projectResource);
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при загрузке данных: {ex.Message}");
            }
            #endregion
            #region Load Job
            try
            {
                var json = File.ReadAllText(_jobPath);
                var jobs = JsonSerializer.Deserialize<List<Job>>(json);

                if (jobs != null)
                {
                    int i = 0;
                    foreach (var job in jobs)
                    {
                        DataStore.Instance.Jobs.Add(i, job);
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при загрузке данных: {ex.Message}");
            }
            #endregion
            #region Load FinanceOperations
            try
            {
                var json = File.ReadAllText(_financeOperationPath);
                var financeOperations = JsonSerializer.Deserialize<List<FinanceOperation>>(json);

                if (financeOperations != null)
                {
                    int i = 0;
                    foreach (var financeOperation in financeOperations)
                    {
                        DataStore.Instance.FinanceOperations.Add(i, financeOperation);
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при загрузке данных: {ex.Message}");
            }
            #endregion
            #region Load Users
            try
            {
                var json = File.ReadAllText(_userPath);
                var users = JsonSerializer.Deserialize<List<User>>(json);

                if (users != null)
                {
                    int i = 0;
                    foreach (var user in users)
                    {
                        DataStore.Instance.Users.Add(i, user);
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при загрузке данных: {ex.Message}");
            }
            #endregion
        }

        public string GetPath()
        {
            return solutionDirectory;
        }
    }
}
