namespace FG.Server.Api.Clients.User.Models.Request.User
{
    public class EditUserPasswordOptions
    {
        public string Email { get; set; } = string.Empty;
        public string LastPassword { get; set; } = string.Empty;
        public string NewPassword { get; set; } = string.Empty;
    }
}
