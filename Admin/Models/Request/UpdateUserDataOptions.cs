namespace FG.Server.Api.Clients.Admin.Models.Request
{
    public class UpdateUserDataOptions
    {
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? CurrentPassword { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
    }
}
