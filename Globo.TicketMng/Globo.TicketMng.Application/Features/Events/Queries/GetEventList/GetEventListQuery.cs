using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globo.TicketMng.Application.Features.Events.Queries.GetEventList
{
    public class GetEventListQuery : IRequest<List<EventListVM>>
    {
    }
}
