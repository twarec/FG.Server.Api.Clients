using Refit;

namespace FG.Server.Api.Clients.Main.Models.Request.Map;

public class GetKitchensFromBoundsOptions
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

    public class TagsFilter
    {
        public List<TagsFilterFromType> TagsMandatory { get; set; } = [];
        public List<TagsFilterFromType> TagsNotMandatory { get; set; } = [];
        public class TagsFilterFromType
        {
            public int Type { get; set; }
            public List<int> Tags { get; set; } = [];
        }
    }
}
