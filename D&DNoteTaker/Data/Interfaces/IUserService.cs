using D_DNoteTaker.Components.Models;

namespace D_DNoteTaker.Data.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers();
        Task<User> GetUserById(string id);
        Task AddUser(User user);
        Task RemoveUser(string id);
        Task UpdateUserData(User user);
    }
}
