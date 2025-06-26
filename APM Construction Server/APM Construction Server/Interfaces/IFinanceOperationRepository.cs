using APM_Construction_Server.Models;

namespace APM_Construction_Server.Interfaces
{
    public interface IFinanceOperationRepository
    {
        List<FinanceOperation> GetAll();
        FinanceOperation GetById(int id);
        void Post(FinanceOperation financeOperation);
        void Put(int id, FinanceOperation financeOperation);
        void Delete(int id);
    }
}
