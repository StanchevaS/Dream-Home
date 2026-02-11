using DreamHome.Common.Validations;
using System.ComponentModel.DataAnnotations;

namespace DreamHome.Models.Account
{
    public class LoginVIewModel
    {
        [Required]
        public string UserName { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
    }
}
