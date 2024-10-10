using Refit;

namespace FG.Server.Api.Clients.Main.Models.Request.Map;

public class GetKitchensFromDistanceOptions
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
