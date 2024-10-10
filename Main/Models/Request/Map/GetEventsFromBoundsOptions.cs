using Refit;

namespace FG.Server.Api.Clients.Main.Models.Request.Map;

public class GetEventsFromBoundsOptions
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
    [Query]
    [AliasAs("dateMin")]
    public DateTime? DateMin { get; set; }
    [Query]
    [AliasAs("dateMax")]
    public DateTime? DateMax { get; set; }
    [Query]
    [AliasAs("startMin")]
    public int? StartMin { get; set; }
    [Query]
    [AliasAs("startMax")]
    public int? StartMax { get; set; }
    [Query]
    [AliasAs("guestsMin")]
    public int? GuestsMin { get; set; }
    [Query]
    [AliasAs("guestsMax")]
    public int? GuestsMax { get; set; }
    [Query]
    [AliasAs("minFreeSeats")]
    public int? MinFreeSeats { get; set; }
    [Query]
    [AliasAs("maxFreeSeats")]
    public int? MaxFreeSeats { get; set; }
    [Query]
    [AliasAs("alcoholEnabled")]
    public bool? AlcoholEnabled { get; set; }
    [Query]
    [AliasAs("isAuto")]
    public bool? IsAuto { get; set; }

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
