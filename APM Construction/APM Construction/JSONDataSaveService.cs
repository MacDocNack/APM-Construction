using APM_Construction.Models;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;
using Task = APM_Construction.Models.Task;

namespace APM_Construction
{
    internal class JSONDataSaveService
    {
        private static JSONDataSaveService _instance = new JSONDataSaveService();
        public static JSONDataSaveService Instance => _instance;

        // Later can use AppData folder to JSON objects
        private static string solutionDirectory = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.Parent?.Parent?.FullName;
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

        public async void SaveProjectData(ObservableCollection<Project> projects)
        {
            try
            {
                string directory = Path.GetDirectoryName(_projectPath);
                if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                string json = JsonSerializer.Serialize(projects);

                await File.WriteAllTextAsync(_projectPath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Faled to save: {ex.Message}");
            }
        }
        public async void SaveClientData(ObservableCollection<Client> clients)
        {
            try
            {
                string directory = Path.GetDirectoryName(_clientPath);
                if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                string json = JsonSerializer.Serialize(clients);

                await File.WriteAllTextAsync(_clientPath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Faled to save: {ex.Message}");
            }
        }
        public async void SaveContractorData(ObservableCollection<Contractor> contractors)
        {
            try
            {
                string directory = Path.GetDirectoryName(_contractorPath);
                if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                string json = JsonSerializer.Serialize(contractors);

                await File.WriteAllTextAsync(_contractorPath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Faled to save: {ex.Message}");
            }
        }
        public async void SaveTaskData(ObservableCollection<Task> tasks)
        {
            try
            {
                string directory = Path.GetDirectoryName(_taskPath);
                if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                string json = JsonSerializer.Serialize(tasks);

                await File.WriteAllTextAsync(_taskPath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Faled to save: {ex.Message}");
            }
        }
        public async void SaveResourceData(ObservableCollection<Resource> resources)
        {
            try
            {
                string directory = Path.GetDirectoryName(_resourcePath);
                if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                string json = JsonSerializer.Serialize(resources);

                await File.WriteAllTextAsync(_resourcePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Faled to save: {ex.Message}");
            }
        }
        public async void SaveEmployeeData(ObservableCollection<Employee> employees)
        {
            try
            {
                string directory = Path.GetDirectoryName(_employeePath);
                if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                string json = JsonSerializer.Serialize(employees);

                await File.WriteAllTextAsync(_employeePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Faled to save: {ex.Message}");
            }
        }
        public async void SaveProjectResourceData(ObservableCollection<ProjectResource> projectResources)
        {
            try
            {
                string directory = Path.GetDirectoryName(_projectResourcePath);
                if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                string json = JsonSerializer.Serialize(projectResources);

                await File.WriteAllTextAsync(_projectResourcePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Faled to save: {ex.Message}");
            }
        }
        public async void SaveJobData(ObservableCollection<Job> jobs)
        {
            try
            {
                string directory = Path.GetDirectoryName(_clientPath);
                if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                string json = JsonSerializer.Serialize(jobs);

                await File.WriteAllTextAsync(_jobPath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Faled to save: {ex.Message}");
            }
        }
        public async void SaveFinanceOperationsData(ObservableCollection<FinanceOperation> financeOperations)
        {
            try
            {
                string directory = Path.GetDirectoryName(_financeOperationPath);
                if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                string json = JsonSerializer.Serialize(financeOperations);

                await File.WriteAllTextAsync(_financeOperationPath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Faled to save: {ex.Message}");
            }
        }
        public async void SaveUsersData(ObservableCollection<User> users)
        {
            try
            {
                string directory = Path.GetDirectoryName(_userPath);
                if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                string json = JsonSerializer.Serialize(users);

                await File.WriteAllTextAsync(_userPath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Faled to save: {ex.Message}");
            }
        }
    }
}
