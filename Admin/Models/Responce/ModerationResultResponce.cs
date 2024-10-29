namespace FG.Server.Api.Clients.Admin.Models.Responce
{
    public class ModerationResultResponce
    {
        public int Id { get; set; }
        public DateTime DateCreate { get; set; }
        public ResponceType Type { get; set; }
        public UserResponce User { get; set; } = new();
    }
}
