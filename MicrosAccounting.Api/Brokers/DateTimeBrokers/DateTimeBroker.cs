namespace MicrosAccounting.Api.Brokers.DateTimeBrokers;

public class DateTimeBroker : IDateTimeBroker
{
    public DateTime GetCurrentDateTime() =>
        DateTime.UtcNow.AddHours(5);
}