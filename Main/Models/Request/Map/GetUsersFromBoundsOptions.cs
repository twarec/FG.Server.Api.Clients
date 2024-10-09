using Refit;

namespace FG.Server.Api.Clients.Main.Models.Request.Map;

public class GetUsersFromBoundsOptions
{
    [Query]
    public double Longitude { get; set; }
    [Query]
    public double Latitude { get; set; }
    [Query]
    public double Longitude_0 { get; set; }
    [Query]
    public double Latitude_0 { get; set; }
    [Query]
    public double Longitude_1 { get; set; }
    [Query]
    public double Latitude_1 { get; set; }
    [Query]
    public int Count { get; set; }
}
