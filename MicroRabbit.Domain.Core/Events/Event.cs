namespace MicroRabbit.Domain.Core.Events;

public abstract class Event
{
    public DateTime Timestamo { get; protected set; }

    protected Event()
    {
        Timestamo = DateTime.Now;
    }
}