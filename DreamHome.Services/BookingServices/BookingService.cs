using DreamHome.Services.Contracts;
using DreamHome.Common.ExceptionTypes;
using DreamHome.Infrastructure.Data.Models.App;
using DreamHome.Infrastructure.Data.Models.User;
using DreamHome.Infrastructure.Repositories.Contracts;
using DreamHome.Services.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DreamHome.Services.BookingServices
{
    public class BookingService : IBookingService
    {
        private readonly IRepository _repository;
        private readonly UserManager<DreamHomeUser> _userManager;
        public BookingService(IRepository repository, UserManager<DreamHomeUser> userManager)
        {
            _repository = repository;
            _userManager = userManager;
        }

        public async Task CreateBooking(CreateBookingDto model)
        {
            var user = await _userManager.FindByIdAsync(model.UserId);

            var room = await _repository.All<Room>()
                .Where(r => r.Number == int.Parse(model.RoomNumber))
                .FirstOrDefaultAsync();

            var accommodationType = await _repository.All<AccommodationType>()
                .Where(a => a.Name == model.AccommodationType)
                .FirstOrDefaultAsync();

            var spaType = await _repository.All<SpaType>()
                .Where(s => s.Name == model.SpaType)
                .FirstOrDefaultAsync();

            if (user == null)
            {
                throw new InvalidReservationException(
                    "Invalid user data!");
            }

            if (room == null)
            {
                throw new InvalidReservationException(
                    "Invalid room data!");
            }

            if (accommodationType == null)
            {
                throw new InvalidReservationException(
                    "Invalid accommodation type!");
            }

            if (spaType == null)
            {
                throw new InvalidReservationException(
                    "Invalid spa type!");
            }

            var reservation = new Reservation()
            {
                UserId = user.Id,
                Room = room,
                RoomId = room.Id,
                AccommodationType = accommodationType,
                AccommodationTypeId = accommodationType.Id,
                SpaType = spaType,
                SpaTypeId = spaType.Id,
                StartDate = DateTime.Parse(model.StartDate),
                EndDate = DateTime.Parse(model.EndDate)
            };

            await _repository.AddAsync(reservation);
            await _repository.SaveChangesAsync();
        }
    }
}
