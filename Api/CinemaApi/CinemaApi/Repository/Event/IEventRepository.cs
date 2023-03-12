namespace CinemaApi.Repository.Event
{
    using Event = CinemaApi.Entities.Entities.Event;

    public interface IEventRepository
    {
        IEnumerable<Event> GetAllEvents();
        Event? GetEventById(int id);
    }
}
