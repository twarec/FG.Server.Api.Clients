namespace FG.Server.Api.Clients.Admin.Models.Request
{
    public class UserAvatarAsAdminOptions
    {
        public int Id { get; set; }
        public string Base64 { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }
}
