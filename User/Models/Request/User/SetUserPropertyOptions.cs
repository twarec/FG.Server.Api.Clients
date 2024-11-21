namespace FG.Server.Api.Clients.User.Models.Request.User
{
    public class SetUserPropertyOptions
    {
        public string StackName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Dictionary<string, string?> Properties { get; set; } = [];
    }
}
