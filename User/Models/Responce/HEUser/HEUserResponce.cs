namespace FG.Server.Api.Clients.User.Models.Responce.HEUser
{
    public class HEUserResponce
    {
        public string Description { get; set; } = string.Empty;
        public string Language { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;

        public List<string> Tags { get; set; } = [];
    }
}
