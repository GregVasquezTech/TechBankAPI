using Microsoft.AspNetCore.Mvc;
using TechBankAPI.Models.UserDetail;
using TechBankAPI.Services.Interfaces;

namespace TechBankAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserDetailController : ControllerBase
    {
        private readonly IUserDetailService _userDetailService;

        public UserDetailController(IUserDetailService userDetailService)
        {
            _userDetailService = userDetailService;
        }


        [HttpGet]
        public async Task<IActionResult> GetUserDetail()
        {
            return Ok(await _userDetailService.GetUserDetailAsync());
        }

        [HttpPost]
        public async Task<IActionResult> CreateUserDetail(CreateUserDetailDto createUserDetailDto)
        {
            return Ok(await _userDetailService.CreateUserDetailAsync(createUserDetailDto));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUserDetail(UpdateUserDetailDto updateUserDetailDto)
        {
            await _userDetailService.UpdateUserDetailAsync(updateUserDetailDto);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUserDetail()
        {
            await _userDetailService.DeleteUserDetailAsync();
            return NoContent();
        }
    }
}
