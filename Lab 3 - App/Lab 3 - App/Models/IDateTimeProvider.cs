namespace Lab_3___App.Models;

public interface IDateTimeProvider
{
    DateTime GetDateTime();
}

public class CurrentDateTimeProvider : IDateTimeProvider
{
    public DateTime GetDateTime() => DateTime.Now;
}