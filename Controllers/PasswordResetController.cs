using Microsoft.AspNetCore.Mvc;

namespace TechBankAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PasswordResetController : ControllerBase
    {
        public PasswordResetController()
        {
        }

        /*        [HttpPost, Authorize]
                public async Task<IActionResult> ResetPassword(CreateUserDetailDto createUserDetailDto)
                {
                    return Ok(await _userDetailService.CreateUserDetailAsync(createUserDetailDto));
                }*/
    }
}
