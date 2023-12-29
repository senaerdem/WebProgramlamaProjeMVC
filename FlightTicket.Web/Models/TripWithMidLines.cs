﻿using FlightTicket.Entity;

namespace FlightTicket.Web.Models
{
    public class TripWithMidLines
    {
        public int Id { get; set; }
        public List<MidLine> MidLines { get; set; } = null!;
    }
}
