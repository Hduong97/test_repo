namespace Globo.TicketMng.Application.Features.Categories.Queries.GetCategoryListWithEvents
{
    public class CategoryEventDto
    {
        public Guid EventId { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public string? Artist { get; set; }
        public DateTime EventDate { get; set; }
        public Guid CategoryId { get; set; }
    }
}