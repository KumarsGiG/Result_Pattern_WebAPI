using Result_Pattern_WebAPI.IRepository;
using Result_Pattern_WebAPI.IServices;
using Result_Pattern_WebAPI.Models.Entities;
using Result_Pattern_WebAPI.Models.ResponseModel;

namespace Result_Pattern_WebAPI.Services
{
    public class UserService : IUserService
    {
        #region ## Instance(s) || Reference(s) ##

        private readonly IUserRepository _userRepository;

        #endregion

        #region ## Constructor(s) ##
        public UserService(IUserRepository userRepository) => _userRepository = userRepository;

        #endregion

        #region ## Method(s) ##

        public async Task<BaseResponse<IEnumerable<User>>> GetUsersAsync()
        {
            var users = await _userRepository.GetUsersAsync();
            return await Task.FromResult(ResultModel.Success(users));
        }

        public async Task<BaseResponse<User>> GetUserAsync(int id)
        {
            var user = await _userRepository.GetUserAsync(id);
            if (user is null)
            {
                return await Task.FromResult(ResultModel.Failure<User>($"User with id {id} not found"));
            }

            return await Task.FromResult(ResultModel.Success(user));
        }

        public async Task<ResultModel> CreateUserAsync(User user)
        {
            if (user is null)
                return await Task.FromResult(ResultModel.Failure("User is null"));

            await _userRepository.CreateUserAsync(user);
            return await Task.FromResult(ResultModel.Success());
        }

        public async Task<ResultModel> UpdateUserAsync(User user)
        {
            if (user == null)
            {
                return await Task.FromResult(ResultModel.Failure("User is null"));
            }

            await _userRepository.UpdateUserAsync(user);
            return await Task.FromResult(ResultModel.Success());
        }

        #endregion
    }
}
