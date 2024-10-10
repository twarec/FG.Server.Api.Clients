using Refit;

namespace FG.Server.Api.Clients.Main.Models.Request.Map;

public class GetUsersFromBoundsOptions
{
    [Query]
    [AliasAs("longitude")]
    public double Longitude { get; set; }
    [Query]
    [AliasAs("latitude")]
    public double Latitude { get; set; }
    [Query]
    [AliasAs("longitude0")]
    public double Longitude_0 { get; set; }
    [Query]
    [AliasAs("latitude0")]
    public double Latitude_0 { get; set; }
    [Query]
    [AliasAs("longitude1")]
    public double Longitude_1 { get; set; }
    [Query]
    [AliasAs("latitude1")]
    public double Latitude_1 { get; set; }
    [Query]
    [AliasAs("count")]
    public int Count { get; set; }
}
