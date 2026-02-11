using DreamHome.Infrastructure.Data.Models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamHome.Infrastructure.Data.Models.App
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Number { get; set; }

        [ForeignKey(nameof(RoomType))]
        public int RoomTypeId { get; set; }
        public RoomType? RoomType { get; set; }

        [Required]
        public bool HasBath { get; set; }

        [Required]
        public bool HasBalcony { get; set; }
    }
}
