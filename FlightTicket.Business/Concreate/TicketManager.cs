﻿using FlightTicket.Business.Abstract;
using FlightTicket.Data.Abstract;
using FlightTicket.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicket.Business.Concreate
{
    public class TicketManager : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;
        public TicketManager(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public async Task CreateAsync(Ticket ticket)
        {
            await _ticketRepository.CreateAsync(ticket);
        }

        public async Task DeleteAsync(Ticket ticket)
        {
            await _ticketRepository.DeleteAsync(ticket);
        }

        public async Task<List<Ticket>> GetAllAsync()
        {
            return await _ticketRepository.GetAllAsync();
        }

        public async Task<Ticket> GetByIdAsync(int id)
        {
            return await _ticketRepository.GetByIdAsync(id);
        }

        public async Task<List<Ticket>> GetTicketsByCustomerIdAsync(int id)
        {
            return await _ticketRepository.GetTicketsByCustomerIdAsync(id);
        }

        public async Task<List<Ticket>> GetTicketsByPnrAsync(string pnr)
        {
            return await _ticketRepository.GetTicketsByPnrAsync(pnr);
        }

        public async Task<List<Ticket>> GetTicketsByUserNameAsync(string userName)
        {
            return await _ticketRepository.GetTicketsByUserNameAsync(userName);
        }

        public async Task<Ticket> GetTicketWithTrip(int id)
        {
            return await _ticketRepository.GetTicketWithTrip(id);
        }

        public async Task UpdateAsync(Ticket ticket)
        {
            await _ticketRepository.UpdateAsync(ticket);
        }
    }
}
