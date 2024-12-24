using Result_Pattern_WebAPI.Models.Entities;
using Result_Pattern_WebAPI.Models.ResponseModel;

namespace Result_Pattern_WebAPI.IServices
{
    public interface IUserService
    {
        #region ## Method(s) ##

        Task<BaseResponse<IEnumerable<User>>> GetUsersAsync();

        Task<BaseResponse<User>> GetUserAsync(int id);

        Task<ResultModel> CreateUserAsync(User user);

        Task<ResultModel> UpdateUserAsync(User user);

        #endregion
    }
}
