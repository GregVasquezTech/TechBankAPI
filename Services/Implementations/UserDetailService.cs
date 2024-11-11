using TechBankAPI.Models.UserDetail;
using TechBankAPI.Services.Interfaces;

namespace TechBankAPI.Services.Implementations
{
    public class UserDetailService : IUserDetailService
    {
        public Task<UserDetailDto> GetUserDetailAsync()
        {
            throw new NotImplementedException();
        }
        public Task<CreateUserDetailDto> CreateUserDetailAsync(CreateUserDetailDto createUserDetailDto)
        {
            throw new NotImplementedException();
        }
        public Task UpdateUserDetailAsync(int userId, UpdateUserDetailDto updateUserDetailDto)
        {
            throw new NotImplementedException();
        }
        public Task DeleteUserDetailAsync(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
