namespace FG.Server.Api.Clients.User.Models.Request.HEUser
{
    public class EditHEUserOptions
    {
        public string Description { get; set; } = string.Empty;
        public string Language { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;

        public bool IsShowLanguage { get; set; } = false;
    }
}
