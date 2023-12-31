﻿using FlightTicket.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicket.Business.Abstract
{
    public interface ILineService
    {
        Task<List<Line>> GetAllAsync();

        Task<Line> GetByIdAsync(int id);

        Task CreateAsync(Line line);

        Task UpdateAsync(Line line);

        Task DeleteAsync(Line line);
        Task<List<Line>> GetLinesBySearchAsync(string from, string to);
        Task<List<Line>> GetLinesWithTripsAsync();
        Task<Line> GetLineWithDetailsAsync(int id);

    }
}
