using System.Data.Entity;
using TechBankAPI.DbContexts;
using TechBankAPI.Entities;
using TechBankAPI.Repositories.Interfaces;

namespace TechBankAPI.Repositories.Implementations
{
    public class UserDetailRepository(ApplicationDbContext _applicationDbContext) : IUserDetailRepository
    {
        public async Task<UserDetail> GetUserDetailAsync(UserDetail userDetail)
        {
            return await _applicationDbContext.UserDetails.FirstAsync(u => u.UserId == userDetail.UserId);
        }
        public async Task<UserDetail> CreateUserDetailAsync(UserDetail userDetail)
        {
            _applicationDbContext.UserDetails.Add(userDetail);
            await _applicationDbContext.SaveChangesAsync();
            return userDetail;
        }
        public async Task UpdateUserDetailAsync(UserDetail userDetail)
        {
            _applicationDbContext.UserDetails.Update(userDetail);
            await _applicationDbContext.SaveChangesAsync();
        }
        public async Task DeleteUserDetailAsync(UserDetail userDetail)
        {
            _applicationDbContext.UserDetails.Remove(userDetail);
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}
