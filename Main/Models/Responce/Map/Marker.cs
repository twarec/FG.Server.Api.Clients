namespace FG.Server.Api.Clients.Main.Models.Responce.Map;

public record class Marker<T>
{
    public Location Location { get; set; }
    public T Value { get; set; }

    public Marker(Location location, T value)
    {
        Location = location;
        Value = value;
    }
}
