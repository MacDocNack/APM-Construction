using APM_Construction_Server.Models;

namespace APM_Construction_Server.Classes
{
    public class ContractorRepository
    {
        public Contractor GetById(int id)
        {
            DataStore.Instance.Contractors.TryGetValue(id, out var contractor);

            return contractor;
        }

        public List<Contractor> GetAll()
        {
            return DataStore.Instance.Contractors.Values.ToList();
        }

        public void Post(Contractor contractor)
        {
            DataStore.Instance.Contractors.Add(contractor.Id, contractor);
        }

        public void Put(int id, Contractor contractor)
        {
            DataStore.Instance.Contractors[contractor.Id] = contractor;
        }

        public void Delete(int id)
        {
            DataStore.Instance.Contractors.Remove(id);
        }
    }
}
