using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentValidation;
using FluentValidation.Results;

namespace Globo.TicketMng.Application.Features.Events.Commands.CreateEvent
{
    public class CreateEventCommandValidator : AbstractValidator<CreateEventCommand>
    {
        public CreateEventCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Not null");
            RuleFor(x => x.Price).GreaterThan(0).WithMessage("0");
        }
    }
}
