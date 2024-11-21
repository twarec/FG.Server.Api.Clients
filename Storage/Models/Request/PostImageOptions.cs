namespace FG.Server.Api.Clients.Storage.Models.Request;

public class PostImageOptions : PostFileOptions
{
    public ImageTransform? Transformation { get; set; }
}