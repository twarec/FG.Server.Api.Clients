namespace FG.Server.Api.Clients.Admin.Models.Responce
{
    public class ModerationUserResponce
    {
        public long Id { get; set; }
        public DateTime DateCreate { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
    }
}
