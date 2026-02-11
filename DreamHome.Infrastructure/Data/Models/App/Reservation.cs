using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamHome.Infrastructure.Data.Models.User;

namespace DreamHome.Infrastructure.Data.Models.App
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Room))]
        public int RoomId { get; set; }
        public Room? Room { get; set; }

        [ForeignKey(nameof(DreamHomeUser))]
        public string UserId { get; set; } = null!;
        public DreamHomeUser? DreamHomeUser { get; set; }

        [ForeignKey(nameof(AccommodationType))]
        public int AccommodationTypeId { get; set; }
        public AccommodationType? AccommodationType { get; set; }

        [ForeignKey(nameof(SpaType))]
        public int SpaTypeId { get; set; }
        public SpaType? SpaType { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public double FinalPrice { get; set; }
    }
}
