﻿using DataTransferObject.DTOClasses;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ServiceInterfaces
{
    public interface ITicketService:IServiceBase<Ticket,TicketDTO,Guid>
    {
        Task<TicketDTO> CreateTicket(TicketDTO ticketDTO);
    }
}
