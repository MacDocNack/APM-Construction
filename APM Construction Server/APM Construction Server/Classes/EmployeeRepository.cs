using APM_Construction_Server.Models;

namespace APM_Construction_Server.Classes
{
    public class EmployeeRepository
    {
        public Employee GetById(int id)
        {
            DataStore.Instance.Employees.TryGetValue(id, out var employee);

            return employee;
        }

        public List<Employee> GetAll()
        {
            return DataStore.Instance.Employees.Values.ToList();
        }

        public void Post(Employee employee)
        {
            DataStore.Instance.Employees.Add(employee.Id, employee);
        }

        public void Put(int id, Employee employee)
        {
            DataStore.Instance.Employees[employee.Id] = employee;
        }

        public void Delete(int id)
        {
            DataStore.Instance.Employees.Remove(id);
        }
    }
}
