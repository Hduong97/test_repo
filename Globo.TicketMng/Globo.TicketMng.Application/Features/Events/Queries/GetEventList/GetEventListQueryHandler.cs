using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Globo.TicketMng.Application.Contracts.Persistence;
using Globo.TicketMng.Domain.Entities;
using MediatR;

namespace Globo.TicketMng.Application.Features.Events.Queries.GetEventList
{
    public class GetEventListQueryHandler : IRequestHandler<GetEventListQuery, List<EventListVM>>
    {
        private readonly IAsyncRepository<Event> _eventRepository;
        private readonly IMapper _mapper;
        public GetEventListQueryHandler(
            IAsyncRepository<Event> eventRepository,
            IMapper mapper
            )
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }
        public async Task<List<EventListVM>> Handle(GetEventListQuery request, CancellationToken cancellationToken)
        {
            var result = await _eventRepository.GetAllAsync();
            return _mapper.Map<List<EventListVM>>(result);
        }
    }
}
