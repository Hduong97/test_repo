using AutoMapper;
using Globo.TicketMng.Application.Contracts.Persistence;
using Globo.TicketMng.Application.Exceptions;
using Globo.TicketMng.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globo.TicketMng.Application.Features.Events.Commands.CreateEvent
{
    public class CreateEventCommandHandler : IRequestHandler<CreateEventCommand, Guid>
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;
        public CreateEventCommandHandler(
            IEventRepository eventRepository,
            IMapper mapper
            )
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateEventCommand request, CancellationToken cancellationToken)
        {
            var validate = new CreateEventCommandValidator();
            var validateResult = await validate.ValidateAsync(request);
            if (validateResult.Errors.Count > 0)
            {
                throw new ValidationException(validateResult);
            }
            var @event = _mapper.Map<Event>(request);
            @event = await _eventRepository.AddAsync(@event);
            return @event.EventId;
        }
    }
}
