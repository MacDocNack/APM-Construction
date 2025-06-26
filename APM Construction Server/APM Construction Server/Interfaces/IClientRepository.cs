using APM_Construction_Server.Models;

namespace APM_Construction_Server.Interfaces
{
    public interface IClientRepository
    {
        List<Client> GetAll();
        Client GetById(int id);
        void Post(Client client);
        void Put(int id, Client client);
        void Delete(int id);
    }
}
