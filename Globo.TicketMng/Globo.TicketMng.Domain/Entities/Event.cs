using Globo.TicketMng.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globo.TicketMng.Domain.Entities
{
    public class Event : AuditableEntity
    {
        public Guid EventId { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public string? Artist { get; set; }
        public DateTime EventDate { get; set; }
        public string? Description { get; set; }
        public string? ImgUrl { get; set; }
        public Guid CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
