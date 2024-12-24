using Result_Pattern_WebAPI.IRepository;
using Result_Pattern_WebAPI.Models.Entities;

namespace Result_Pattern_WebAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        #region ## Properties || Instances ##

        private static List<User> _users = new();

        #endregion

        #region ## Constructor(s) ##

        public UserRepository()
        {
            _users = new()
            {
                new User { Id = 1, Name = "John Doe", Email = "joh@gmail.com"},
                new User { Id = 2, Name = "Jane Smith", Email = "jane@gmail.com"},
                new User { Id = 3, Name = "Alice Johnson", Email = "alice@gmail.com"},
                new User { Id = 4, Name = "Bob Brown", Email = "bob@gmail.com"},
                new User { Id = 5, Name = "Emily Davis", Email = "emily@gmail.com"},
                new User { Id = 6, Name = "Michael Wilson", Email = "michael@gmail.com"},
                new User { Id = 7, Name = "Sophia Taylor", Email = "sophia@gmail.com"},
                new User { Id = 8, Name = "James Martinez", Email = "james@gmail.com"},
                new User { Id = 9, Name = "Olivia Garcia", Email = "olivia@gmail.com"},
                new User { Id = 10, Name = "William Rodriguez", Email = "william@gmail.com"}
            };
        }

        #endregion

        #region ## Method(s) ##

        public async Task<IEnumerable<User>> GetUsersAsync() => await Task.FromResult(_users);

        public async Task<User> GetUserAsync(int id) => await Task.FromResult(result: _users.Find(u => u.Id == id));

        public async Task CreateUserAsync(User user)
        {
            _users.Add(user);
        }

        public async Task UpdateUserAsync(User user)
        {
            var existingUser = _users.FirstOrDefault(u => u.Id == user.Id);
            if (existingUser is not null)
            {
                existingUser.Name = user.Name;
                existingUser.Email = user.Email;
            }
        }

        #endregion
    }
}
