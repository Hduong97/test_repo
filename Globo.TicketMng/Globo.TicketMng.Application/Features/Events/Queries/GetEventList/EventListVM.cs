namespace Globo.TicketMng.Application.Features.Events.Queries.GetEventList
{
    public class EventListVM
    {
        public Guid EventId { get; set; }
        public string? Name { get; set; }
        public DateTime EventDate { get; set; }
        public string? ImgUrl { get; set; }
    }
}