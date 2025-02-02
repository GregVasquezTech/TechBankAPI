namespace TechBankAPI.Services.Interfaces
{
    public interface IPasswordResetService
    {
        public System.Threading.Tasks.Task SendPasswordResetEmail(string email);
        public System.Threading.Tasks.Task ResetPassword();
    }
}
