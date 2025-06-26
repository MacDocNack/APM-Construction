using APM_Construction_Server.Models;

namespace APM_Construction_Server.Classes
{
    public class FinanceOperationRepository
    {
        public FinanceOperation GetById(int id)
        {
            DataStore.Instance.FinanceOperations.TryGetValue(id, out var financeOperationData);

            return financeOperationData;
        }

        public List<FinanceOperation> GetAll()
        {
            return DataStore.Instance.FinanceOperations.Values.ToList();
        }

        public void Post(FinanceOperation financeOperationData)
        {
            if (FoundData(financeOperationData))
                DataStore.Instance.FinanceOperations.Add(financeOperationData.Id, financeOperationData);
        }

        public void Put(int id, FinanceOperation financeOperationData)
        {
            if (FoundData(financeOperationData))
                DataStore.Instance.FinanceOperations[financeOperationData.Id] = financeOperationData;
        }

        public void Delete(int id)
        {
            DataStore.Instance.FinanceOperations.Remove(id);
        }

        private bool FoundData(FinanceOperation financeOperationData)
        {
            if (!DataStore.Instance.Projects.TryGetValue(financeOperationData.IdProject, out var project))
                return false;
            return true;
        }
    }
}
