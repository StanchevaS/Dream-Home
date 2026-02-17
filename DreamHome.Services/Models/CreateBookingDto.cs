namespace DreamHome.Services.Models
{
    public class CreateBookingDto
    {
        public string UserId { get; set; } = null!;

        public string RoomNumber { get; set; } = null!;
        
        public string AccommodationType { get; set; } = null!;
        
        public string SpaType { get; set; } = null!;
        
        public string StartDate { get; set; } = null!;
        
        public string EndDate { get; set; } = null!;
    }
}
