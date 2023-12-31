﻿using FlightTicket.Entity;
using System.ComponentModel.DataAnnotations;

namespace FlightTicket.Web.Models
{
    public class UpdateLineModel
    {
        public int LineId { get; set; }
        public List<string> Stops { get; set; } = null!;
        public List<string> Time { get; set; } = null!;
        public List<string> Fares { get; set; } = null!;
        public List<StopTimeFareModel>? StopTimeFares { get; set; } = null!;
        [Required(ErrorMessage = "FlightId Must be selected")]
        public int? FlightId { get; set; }
        [Required(ErrorMessage = "Driver Must be selected")]
        public int? DriverId { get; set; }

        [Required(ErrorMessage = "Date Must be selected")]
        public string Date { get; set; }
        public List<Flight>? Flightes { get; set; }
        public List<Driver>? Drivers { get; set; }
    }
}
