using TechBankAPI.Entities;

namespace TechBankAPI.Repositories.Interfaces
{
    public interface IUserDetailRepository
    {
        public Task<UserDetail> GetUserDetailAsync();
        public Task<UserDetail> CreateUserDetailAsync(UserDetail userDetail);
        public System.Threading.Tasks.Task UpdateUserDetailAsync(int userId);
        public System.Threading.Tasks.Task DeleteUserDetailAsync(int userId);
    }
}
