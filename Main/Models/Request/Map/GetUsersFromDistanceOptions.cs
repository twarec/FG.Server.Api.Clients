using Refit;

namespace FG.Server.Api.Clients.Main.Models.Request.Map;

public class GetUsersFromDistanceOptions
{
	[Query]
	[AliasAs("longitude")]
	public double Longitude { get; set; }
	[Query]
	[AliasAs("latitude")]
	public double Latitude { get; set; }
	[Query]
	[AliasAs("distance")]
	public double Disatnce { get; set; }
	[Query]
	[AliasAs("count")]
	public int Count { get; set; }

}
