using DataTransferObject.DTOClasses;
using Infrastructure.RepositoryPattern;
using Mapster;
using Microsoft.AspNetCore.Identity;
using Model.Entities;
using Service.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ServiceClasses
{
    public class TicketService : ITicketService
    {
        private readonly IBaseRepository<Ticket,Guid> _ticketRepository;
        public TicketService(IBaseRepository<Ticket, Guid> ticketRepository)
        {
            _ticketRepository = ticketRepository;
            
        }

        public async Task<TicketDTO> CreateTicket(TicketDTO ticketDTO)
        {
            var data = TranslateToEntity(ticketDTO);
            await _ticketRepository.CreateDataAsync(data);
            return ticketDTO;
        }

        public TicketDTO TranslateToDTO(Ticket entity)
        {
           return entity.Adapt<TicketDTO>();    
        }

        public Ticket TranslateToEntity(TicketDTO dto)
        {
           return dto.Adapt<Ticket>();
        }
    }
}
