using TechBankAPI.Models.UserDetail;

namespace TechBankAPI.Services.Interfaces
{
    public interface IUserDetailService
    {
        public Task<UserDetailDto> GetUserDetailAsync();
        public Task<CreateUserDetailDto> CreateUserDetailAsync(CreateUserDetailDto createUserDetailDto);
        public System.Threading.Tasks.Task UpdateUserDetailAsync(UpdateUserDetailDto updateUserDetailDto);
        public System.Threading.Tasks.Task DeleteUserDetailAsync();
    }
}
