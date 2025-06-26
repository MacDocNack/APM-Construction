using APM_Construction_Server.Models;

namespace APM_Construction_Server.Classes
{
    public class ClientRepository
    {
        public Client GetById(int id)
        {
            DataStore.Instance.Clients.TryGetValue(id, out var client);

            return client;
        }

        public List<Client> GetAll()
        {
            return DataStore.Instance.Clients.Values.ToList();
        }

        public void Post(Client client)
        {
            DataStore.Instance.Clients.Add(client.Id, client);
        }

        public void Put(int id, Client client)
        {
            DataStore.Instance.Clients[client.Id] = client;
        }

        public void Delete(int id)
        {
            DataStore.Instance.Clients.Remove(id);
        }
    }
}
