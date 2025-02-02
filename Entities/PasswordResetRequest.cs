namespace TechBankAPI.Entities
{
    public class PasswordResetRequest
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public DateTime RequestedAt { get; set; }
    }
}
