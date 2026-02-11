using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamHome.Infrastructure.Data.Models.App
{
    public class Photo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public byte[] PhotoFile { get; set; } = null!;

        [ForeignKey(nameof(Room))]
        public int RoomId { get; set; }

        public Room? Room { get; set; }
    }
}
