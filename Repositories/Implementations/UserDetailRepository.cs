using TechBankAPI.Entities;
using TechBankAPI.Repositories.Interfaces;

namespace TechBankAPI.Repositories.Implementations
{
    public class UserDetailRepository : IUserDetailRepository
    {
        public Task<UserDetail> GetUserDetailAsync()
        {
            throw new NotImplementedException();
        }
        public Task<UserDetail> CreateUserDetailAsync(UserDetail userDetail)
        {
            throw new NotImplementedException();
        }
        public Task UpdateUserDetailAsync(int userId)
        {
            throw new NotImplementedException();
        }
        public Task DeleteUserDetailAsync(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
