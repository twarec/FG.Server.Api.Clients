using Refit;

namespace FG.Server.Api.Clients.Main.Models.Request.Map;

public class GetUsersFromDistanceOptions
{
    [Query]
    public double Longitude { get; set; }
    [Query]
    public double Latitude { get; set; }
    [Query]
    public double Disatnce { get; set; }
    [Query]
    public int Count { get; set; }

}
