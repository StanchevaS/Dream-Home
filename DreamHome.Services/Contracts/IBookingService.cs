using DreamHome.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamHome.Services.Contracts
{
    public interface IBookingService
    {
        Task CreateBooking(CreateBookingDto model);
    }
}
