using APM_Construction_Server.Models;

namespace APM_Construction_Server.Interfaces
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAll();
        Employee GetById(int id);
        void Post(Employee employee);
        void Put(int id, Employee employee);
        void Delete(int id);
    }
}
