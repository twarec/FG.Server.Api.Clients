using FG.Server.Api.Clients.Main.Models.Request.Map;
using FG.Server.Api.Clients.Main.Models.Responce.Map;
using Refit;

namespace FG.Server.Api.Clients.Main.Controllers;

public interface IEventController
{
    [Post("")]
    public Task<IEnumerable<Marker<EventMarkerValue>>> GetEventsFromDistanceAsync(GetEventsFromDistanceOptions options, [Body] GetEventsFromDistanceOptions.TagsFilter? tags);
    [Post("")]
    public Task<IEnumerable<Marker<EventMarkerValue>>> GetEventsFromBoundsAsync(GetEventsFromBoundsOptions options, [Body] GetEventsFromBoundsOptions.TagsFilter? tags);
}
