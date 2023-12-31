﻿using FlightTicket.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicket.Data.Abstract
{
    public interface ITripRepository : IRepository<Trip>
    {
        Task<List<Trip>> GetAllTripsWDetails();
        Task<List<Trip>> GetTripsBySearch(string origin, string destination, string date);
        Task<List<Trip>> GetTripsBySearchAndLine(string origin, string destination, string date, int lineId);
        Task<Trip> GetTripWithDetails(int id);
    }
}
