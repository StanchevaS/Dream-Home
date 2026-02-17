using AutoMapper;
using DreamHome.Models;
using DreamHome.Services.Contracts;
using DreamHome.Services.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DreamHome.Controllers
{
    [Authorize]
    public class BookingController : Controller
    {
        private readonly IBookingService _bookingService;
        private readonly IMapper _mapper;

        public BookingController(IBookingService bookingService, IMapper mapper)
        {
            _bookingService = bookingService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult CreateBooking()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBooking(CreateBookingVIewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var bookingDto = _mapper.Map<CreateBookingDto>(model);

            await _bookingService.CreateBooking(bookingDto);

            return View(model);
        }
    }
}
