using TechBankAPI.Models.UserDetail;
using TechBankAPI.Repositories.Interfaces;
using TechBankAPI.Services.Interfaces;

namespace TechBankAPI.Services.Implementations
{
    public class UserDetailService(IUserDetailRepository userDetailRepository) : IUserDetailService
    {
        public async Task<UserDetailDto> GetUserDetailAsync()
        {
            throw new NotImplementedException();
        }
        public Task<CreateUserDetailDto> CreateUserDetailAsync(CreateUserDetailDto createUserDetailDto)
        {
            throw new NotImplementedException();
        }
        public Task UpdateUserDetailAsync(UpdateUserDetailDto updateUserDetailDto)
        {
            throw new NotImplementedException();
        }
        public Task DeleteUserDetailAsync()
        {
            throw new NotImplementedException();
        }
    }
}
