namespace FG.Server.Api.Clients.Main.Models.Responce.Map;

public class Marker<T>(Location location, T value)
{
    public Location Location => location;
    public T Value => value;
}
