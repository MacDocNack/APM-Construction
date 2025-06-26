using APM_Construction_Server.Interfaces;
using APM_Construction_Server.Models;

namespace APM_Construction_Server.Classes
{
    public class UserRepository : IUserRepository
    {
        public List<User> GetAll()
        {
            return DataStore.Instance.Users.Values.ToList();
        }

        public User GetById(int id)
        {
            DataStore.Instance.Users.TryGetValue(id, out User user);
            return user;
        }

        public void Post(User user)
        {
            DataStore.Instance.Users.Add(user.Id, user);
        }

        public void Put(int id, User user)
        {
            DataStore.Instance.Users[user.Id] =  user;
        }
        public void Delete(int id)
        {
            DataStore.Instance.Users.Remove(id);
        }
    }
}
