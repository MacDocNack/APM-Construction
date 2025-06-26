using APM_Construction_Server.Models;

namespace APM_Construction_Server.Interfaces
{
    public interface IContractorRepository
    {
        List<Contractor> GetAll();
        Contractor GetById(int id);
        void Post(Contractor contractor);
        void Put(int id, Contractor contractor);
        void Delete(int id);
    }
}
