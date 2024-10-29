namespace FG.Server.Api.Clients.Admin.Models.Request
{
    public class UpdateUserDataAsAdminOptions
    {
        public int UserId { get; set; }
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Password { get; set; }
        public UserRole? Role { get; set; }
        public string? Avatar { get; set; }
    }
}
