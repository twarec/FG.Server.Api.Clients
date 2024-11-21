namespace FG.Server.Api.Clients.Storage.Models.Request;

public class PutImageOptions : PutContentOptions
{
    public ImageTransform? Transformation { get; set; }
}

