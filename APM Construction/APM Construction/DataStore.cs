using APM_Construction.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Task = APM_Construction.Models.Task;

namespace APM_Construction
{
    public class DataStore : INotifyPropertyChanged
    {
        private static readonly DataStore _instance = new();
        public static DataStore Instance => _instance;

        private ObservableCollection<Client> _clients { get; set; }
        private ObservableCollection<Contractor> _contractors { get; set; }
        private ObservableCollection<Employee> _employees { get; set; }
        private ObservableCollection<FinanceOperation> _financeOperations { get; set; }
        private ObservableCollection<Job> _jobs { get; set; }
        private ObservableCollection<Project> _projects { get; set; }
        private ObservableCollection<ProjectResource> _projectResources { get; set; }
        private ObservableCollection<Resource> _resources { get; set; }
        private ObservableCollection<Task> _tasks { get; set; }
        private ObservableCollection<User> _users { get; set; }
        private ObservableCollection<Role> _roles { get; set; }

        public User CurrentUser { get; set; }

        public ObservableCollection<Client> Clients
        {
            get
            {
                _clients ??= [];
                return _clients;
            }
            set
            {
                Clients = value;
                OnPropertyChanged(nameof(Clients));
            }
        }
        public ObservableCollection<Contractor> Contractors
        {
            get
            {
                _contractors ??= [];
                return _contractors;
            }
            set
            {
                Contractors = value;
                OnPropertyChanged(nameof(Contractors));
            }
        }
        public ObservableCollection<Employee> Employees
        {
            get
            {
                _employees ??= [];
                return _employees;
            }
            set
            {
                Employees = value;
                OnPropertyChanged(nameof(Employees));
            }
        }
        public ObservableCollection<FinanceOperation> FinanceOperations
        {
            get
            {
                _financeOperations ??= [];
                return _financeOperations;
            }
            set
            {
                FinanceOperations = value;
                OnPropertyChanged(nameof(FinanceOperations));
            }
        }
        public ObservableCollection<Job> Jobs
        {
            get
            {
                _jobs ??= [];
                return _jobs;
            }
            set
            {
                Jobs = value;
                OnPropertyChanged(nameof(Jobs));
            }
        }
        public ObservableCollection<Project> Projects
        {
            get
            {
                _projects ??= [];
                return _projects;
            }
            set
            {
                Projects = value;
                OnPropertyChanged(nameof(Projects));
            }
        }
        public ObservableCollection<ProjectResource> ProjectResources
        {
            get
            {
                _projectResources ??= [];
                return _projectResources;
            }
            set
            {
                ProjectResources = value;
                OnPropertyChanged(nameof(ProjectResources));
            }
        }
        public ObservableCollection<Resource> Resources
        {
            get
            {
                _resources ??= [];
                return _resources;
            }
            set
            {
                Resources = value;
                OnPropertyChanged(nameof(Resources));
            }
        }
        public ObservableCollection<Task> Tasks
        {
            get
            {
                _tasks ??= [];
                return _tasks;
            }
            set
            {
                Tasks = value;
                OnPropertyChanged(nameof(Tasks));
            }
        }

        public ObservableCollection<User> Users
        {
            get
            {
                _users ??= [];
                return _users;
            }
            set
            {
                Users = value;
                OnPropertyChanged(nameof(Users));
            }
        }
        public ObservableCollection<Role> Roles
        {
            get
            {
                _roles ??= [];
                return _roles;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void LoadAll(ConnectToWeb connectToWeb)
        {
            LoadClients(connectToWeb);
            LoadContractors(connectToWeb);
            LoadEmployees(connectToWeb);
            LoadFinanceOperations(connectToWeb);
            LoadJobs(connectToWeb);
            LoadProjects(connectToWeb);
            LoadProjectResources(connectToWeb);
            LoadResources(connectToWeb);
            LoadTasks(connectToWeb);
            LoadUsers(connectToWeb);
        }

        private async void LoadClients(ConnectToWeb connectToWeb)
        {
            var clientList = await connectToWeb.GetClientsAsync();
            foreach (var client in clientList)
            {
                Clients.Add(client);
            }
        }
        private async void LoadContractors(ConnectToWeb connectToWeb)
        {
            var contractorsList = await connectToWeb.GetContractorsAsync();
            foreach (var contractor in contractorsList)
            {
                Contractors.Add(contractor);
            }
        }
        private async void LoadEmployees(ConnectToWeb connectToWeb)
        {
            var employeesList = await connectToWeb.GetEmployeesAsync();
            foreach (var employee in employeesList)
            {
                Employees.Add(employee);
            }
        }
        private async void LoadFinanceOperations(ConnectToWeb connectToWeb)
        {
            var financeOperationsList = await connectToWeb.GetFinanceOperationsAsync();
            foreach (var financeOperation in financeOperationsList)
            {
                FinanceOperations.Add(financeOperation);
            }
        }
        private async void LoadJobs(ConnectToWeb connectToWeb)
        {
            var jobsList = await connectToWeb.GetJobsAsync();
            foreach (var job in jobsList)
            {
                Jobs.Add(job);
            }
        }
        private async void LoadProjects(ConnectToWeb connectToWeb)
        {
            var projectsList = await connectToWeb.GetProjectsAsync();
            foreach (var project in projectsList)
            {
                Projects.Add(project);
            }
        }
        private async void LoadProjectResources(ConnectToWeb connectToWeb)
        {
            var projectResourcesList = await connectToWeb.GetProjectResourcesAsync();
            foreach (var projectResource in projectResourcesList)
            {
                ProjectResources.Add(projectResource);
            }
        }
        private async void LoadResources(ConnectToWeb connectToWeb)
        {
            var resourcesList = await connectToWeb.GetResourcesAsync();
            foreach (var resource in resourcesList)
            {
                Resources.Add(resource);
            }
        }
        private async void LoadTasks(ConnectToWeb connectToWeb)
        {
            var taskList = await connectToWeb.GetTasksAsync();
            foreach (var task in taskList)
            {
                Tasks.Add(task);
            }
        }
        private async void LoadUsers(ConnectToWeb connectToWeb)
        {
            var userList = await connectToWeb.GetUsersAsync();
            foreach (var user in userList)
            {
                Users.Add(user);
            }
        }
    }
}
