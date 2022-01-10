using MediatR;
using System;

namespace GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventDetails
{
    public class GetEventDetailQuery : IRequest<EventDetailVm>
    {
        public Guid Id { get; set; }
    }
}
