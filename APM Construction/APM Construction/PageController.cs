using APM_Construction.Pages;
using APM_Construction.Windows;
using APM_Construction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace APM_Construction
{
    public class PageController
    {
        private static MainPage _mainPage;
        private static ProjectPage _projectPage;
        private static TaskPage _taskPage;
        private static ResourcePage _resourcePage;
        private static EmployeePage _employeePage;
        private static ProjectCreateForm _projectCreateForm;
        private static ProjectEditForm _projectEditForm;
        private static ProjectViewForm _projectViewForm;
        private static TaskCreateForm _taskCreateForm;
        private static TaskEditForm _taskEditForm;
        private static TaskViewForm _taskViewForm;
        private static ResourcesForm _resourcesForm;
        private static EmployeeForm _employeeForm;
        private static RegistrationPage _registrationPage;
        private static AuthorizationPage _authorizationPage;

        public static MainPage MainPage
        {
            get
            {
                _mainPage ??= new MainPage();
                return _mainPage;
            }
        }
        public static ProjectPage ProjectPage
        {
            get
            {
                _projectPage ??= new ProjectPage();
                return _projectPage;
            }
        }
        public static TaskPage TaskPage
        {
            get
            {
                _taskPage ??= new TaskPage();
                return _taskPage;
            }
        }
        public static ResourcePage ResourcePage
        {
            get
            {
                _resourcePage ??= new ResourcePage();
                return _resourcePage;
            }
        }
        public static EmployeePage EmployeePage
        {
            get
            {
                _employeePage ??= new EmployeePage();
                return _employeePage;
            }
        }
        public static ProjectCreateForm ProjectCreateForm
        {
            get
            {
                _projectCreateForm ??= new ProjectCreateForm();
                return _projectCreateForm;
            }
        }
        public static ProjectEditForm ProjectEditForm
        {
            get
            {
                _projectEditForm ??= new ProjectEditForm();
                return _projectEditForm;
            }
        }
        public static ProjectViewForm ProjectViewForm
        {
            get
            {
                _projectViewForm ??= new ProjectViewForm();
                return _projectViewForm;
            }
        }
        public static TaskCreateForm TaskCreateForm
        {
            get
            {
                _taskCreateForm ??= new TaskCreateForm();
                return _taskCreateForm;
            }
        }
        public static TaskEditForm TaskEditForm
        {
            get
            {
                _taskEditForm ??= new TaskEditForm();
                return _taskEditForm;
            }
        }
        public static TaskViewForm TaskViewForm
        {
            get
            {
                _taskViewForm ??= new TaskViewForm();
                return _taskViewForm;
            }
        }
        public static ResourcesForm ResourcesForm
        {
            get
            {
                _resourcesForm ??= new ResourcesForm();
                return _resourcesForm;
            }
        }
        public static EmployeeForm EmployeeForm
        {
            get
            {
                _employeeForm ??= new EmployeeForm();
                return _employeeForm;
            }
        }
        public static RegistrationPage RegistrationPage
        {
            get
            {
                _registrationPage ??= new RegistrationPage();
                return _registrationPage;
            }
        }
        public static AuthorizationPage AuthorizationPage
        {
            get
            {
                _authorizationPage ??= new AuthorizationPage();
                return _authorizationPage;
            }
        }

        public static void GetPageForSelectedResource(string namePage, object resourceToAdd)
        {
            switch (namePage)
            {
                case "ProjectCreateForm":
                    ProjectCreateForm.RequiredResourceList.Items.Add(resourceToAdd);
                    break;
                case "ProjectEditForm":
                    ProjectEditForm.RequiredResourceList.Items.Add(resourceToAdd);
                    break;
                default:
                    break;
            }
        }
    }
}
