using AutoMapper;
using GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
using GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using GloboTicket.TicketManagement.Application.Features.Events.Commands.CreateEvent;
using GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventDetails;
using GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventList;
using GloboTicket.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GloboTicket.TicketManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Event, CategoryDto>();
            CreateMap<Event, CategoryListVm>();
            CreateMap<Event, CategoryEventListVm>();
            CreateMap<Event, CategoryEventListVm>();
            CreateMap<Event, CreateEventCommand>().ReverseMap();
        }
    }
}
