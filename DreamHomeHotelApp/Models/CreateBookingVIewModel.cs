using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace DreamHome.Models
{
    public class CreateBookingVIewModel
    {
        [Required]
        public string RoomNumber { get; set; } = null!;

        [Required]
        public string AccommodationType { get; set; } = null!;

        [Required]
        public string SpaType { get; set; } = null!;

        [Required]
        public string StartDate { get; set; } = null!;

        [Required]
        public string EndDate { get; set; } = null!;
    }
}