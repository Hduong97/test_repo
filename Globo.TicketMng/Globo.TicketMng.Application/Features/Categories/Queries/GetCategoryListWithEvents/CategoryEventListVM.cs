using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globo.TicketMng.Application.Features.Categories.Queries.GetCategoryListWithEvents
{
    public class CategoryEventListVM
    {
        public Guid CategoryId { get; set; }
        public string? Name { get; set; }
        public ICollection<CategoryEventDto>? Events  { get; set; }
    }
}
