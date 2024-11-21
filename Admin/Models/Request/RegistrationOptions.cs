namespace FG.Server.Api.Clients.Admin.Models.Request
{
    public class RegistrationOptions
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public UserRole Role { get; set; } = UserRole.Moderator;
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
