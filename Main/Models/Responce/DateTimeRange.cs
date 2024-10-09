namespace FG.Server.Api.Clients.Main.Models.Responce;

public class DateTimeRange
{
    public long Start { get; set; } = DateTime.Now.ToBinary();
    public long Stop { get; set; } = DateTime.Now.ToBinary();

    public DateTimeRange()
    {

    }
    public DateTimeRange(DateTime start, DateTime stop)
    {
        Start = start.ToBinary();
        Stop = stop.ToBinary();
    }
}
