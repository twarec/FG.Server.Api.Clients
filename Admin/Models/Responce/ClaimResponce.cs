namespace FG.Server.Api.Clients.Admin.Models.Responce
{
    public class ClaimResponce
    {
        public int Id { get; set; }
        public DateTime DateCreate { get; set; }
        public string Content { get; set; } = string.Empty;
        public string Grouped { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string External { get; set; } = string.Empty;
        public ModerationUserResponce ModerationUser { get; set; } = new();
        public ModerationResultResponce Responce { get; set; } = new();
    }
}
