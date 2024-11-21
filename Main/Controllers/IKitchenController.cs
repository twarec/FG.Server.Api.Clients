using FG.Server.Api.Clients.Main.Models.Request.Map;
using FG.Server.Api.Clients.Main.Models.Responce.Map;
using Refit;

namespace FG.Server.Api.Clients.Main.Controllers;

public interface IKitchenController
{
	[Post("/Kitchen/Geo/Markers/Distance/Range")]
	public Task<IEnumerable<Marker<KitchenMarkerValue>>> GetRangeFromDistanceAsync(GetKitchensFromDistanceOptions options, [Body] GetKitchensFromDistanceOptions.TagsFilter? tags);
	[Post("/Kitchen/Geo/Markers/Distance/Range")]
	public Task<IEnumerable<Marker<KitchenMarkerValue>>> GetRangeFromBoundsAsync(GetKitchensFromBoundsOptions options, [Body] GetKitchensFromBoundsOptions.TagsFilter? tags);
}
