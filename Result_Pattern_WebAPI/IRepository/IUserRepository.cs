using Result_Pattern_WebAPI.Models.Entities;

namespace Result_Pattern_WebAPI.IRepository
{
    public interface IUserRepository
    {
        #region ## Method(s) ##

        Task<IEnumerable<User>> GetUsersAsync();

        Task<User> GetUserAsync(int id);

        Task CreateUserAsync(User user);

        Task UpdateUserAsync(User user);

        #endregion
    }
}
