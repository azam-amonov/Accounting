namespace MicrosAccounting.Api.Brokers.DateTimeBrokers;

public interface IDateTimeBroker
{
    DateTimeOffset GetCurrentDateTimeOffset();
}