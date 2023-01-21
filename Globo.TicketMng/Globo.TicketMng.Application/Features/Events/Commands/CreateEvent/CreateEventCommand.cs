using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globo.TicketMng.Application.Features.Events.Commands.CreateEvent
{
    public class CreateEventCommand : IRequest<Guid>
    {
        public Guid EventId { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public string? Artist { get; set; }
        public DateTime EventDate { get; set; }
        public string? Description { get; set; }
        public string? ImgUrl { get; set; }
        public Guid CategoryId { get; set; }

        public override string ToString()
        {
            return $"EventId {EventId}";
        }
    }
}
