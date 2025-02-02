using AutoMapper;
using TechBankAPI.Models.UserDetail;
using TechBankAPI.Repositories.Interfaces;
using TechBankAPI.Services.Interfaces;

namespace TechBankAPI.Services.Implementations
{
    public class UserDetailService : IUserDetailService
    {
        private readonly IMapper _mapper;
        private readonly IUserDetailRepository _userDetailRepository;

        public UserDetailService(IMapper mapper, IUserDetailRepository userDetailRepository)
        {
            _mapper = mapper;
            _userDetailRepository = userDetailRepository;
        }
        public async Task<string> GetUserEmailAsync()
        {
            if (HttpContext.Sess)
        }
        public async Task<UserDetailDto> GetUserDetailAsync()
        {
            return _mapper.Map<UserDetailDto>(_userDetailRepository.GetUserDetailAsync();
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
