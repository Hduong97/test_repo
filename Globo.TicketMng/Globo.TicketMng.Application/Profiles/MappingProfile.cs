using AutoMapper;
using Globo.TicketMng.Application.Features.Categories.Queries.GetCategoryList;
using Globo.TicketMng.Application.Features.Categories.Queries.GetCategoryListWithEvents;
using Globo.TicketMng.Application.Features.Events;
using Globo.TicketMng.Application.Features.Events.Commands.CreateEvent;
using Globo.TicketMng.Application.Features.Events.Queries.GetEventList;
using Globo.TicketMng.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globo.TicketMng.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVM>().ReverseMap();
            CreateMap<Category, CategoryListVM>().ReverseMap();
            CreateMap<Category, CategoryEventListVM>();
            CreateMap<Event, CreateEventCommand>().ReverseMap();
        }
    }
}
