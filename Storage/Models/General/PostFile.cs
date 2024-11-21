using System.ComponentModel.DataAnnotations;

namespace FG.Server.Api.Clients.Storage.Models.General;

public class PostFile
{
    [Required]
    public string Base64 { get; set; } = string.Empty;
    [Required]
    public string Name { get; set; } = string.Empty;
}