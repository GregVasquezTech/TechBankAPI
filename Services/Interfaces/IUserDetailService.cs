using TechBankAPI.Models.UserDetail;

namespace TechBankAPI.Services.Interfaces
{
    public interface IUserDetailService
    {
        public Task<UserDetailDto> GetUserDetailAsync();
        public Task<CreateUserDetailDto> CreateUserDetailAsync(CreateUserDetailDto createUserDetailDto);
        public System.Threading.Tasks.Task UpdateUserDetailAsync(int userId, UpdateUserDetailDto updateUserDetailDto);
        public System.Threading.Tasks.Task DeleteUserDetailAsync(int userId);
    }
}
