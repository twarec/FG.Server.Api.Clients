using FG.Server.Api.Clients.Main.Models.Request.Map;
using FG.Server.Api.Clients.Main.Models.Responce.Map;
using Refit;

namespace FG.Server.Api.Clients.Main.Controllers;

public interface IEventController
{
    [Post("/Event/Geo/Markers/Distance/Range")]
    public Task<IEnumerable<Marker<EventMarkerValue>>> GetEventsFromDistanceAsync(GetEventsFromDistanceOptions options, [Body] GetEventsFromDistanceOptions.TagsFilter? tags);
    [Post("/Event/Geo/Markers/Distance/Range")]
    public Task<IEnumerable<Marker<EventMarkerValue>>> GetEventsFromBoundsAsync(GetEventsFromBoundsOptions options, [Body] GetEventsFromBoundsOptions.TagsFilter? tags);
}
