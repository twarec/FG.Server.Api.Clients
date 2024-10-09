using FG.Server.Api.Clients.Main.Models.Request.Map;
using FG.Server.Api.Clients.Main.Models.Responce.Map;
using Refit;

namespace FG.Server.Api.Clients.Main.Controllers;

public interface IUserController
{
    [Get("/User/Geo/Markers/Distance/Range")]
    public Task<IEnumerable<Marker<UserMarkerValue>>> GetRangeFromDistanceAsync(GetUsersFromDistanceOptions options);
    [Get("/User/Geo/Markers/Distance/Range")]
    public Task<IEnumerable<Marker<UserMarkerValue>>> GetRangeFromBoundsAsync(GetUsersFromBoundsOptions options);

}
