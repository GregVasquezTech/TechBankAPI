using TechBankAPI.Entities;

namespace TechBankAPI.Repositories.Interfaces
{
    public interface IUserDetailRepository
    {
        public Task<UserDetail> GetUserDetailAsync(UserDetail userDetail);
        public Task<UserDetail> CreateUserDetailAsync(UserDetail userDetail);
        public System.Threading.Tasks.Task UpdateUserDetailAsync(UserDetail userDetail);
        public System.Threading.Tasks.Task DeleteUserDetailAsync(UserDetail userDetail);
    }
}
