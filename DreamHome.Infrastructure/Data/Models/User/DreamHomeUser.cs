using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamHome.Common.Validations;
using Microsoft.AspNetCore.Identity;

namespace DreamHome.Infrastructure.Data.Models.User
{
    public class DreamHomeUser : IdentityUser
    {
        [Required]
        [MinLength(DbValidationConstants.FirstNameMinLength)]
        [MaxLength(DbValidationConstants.FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MinLength(DbValidationConstants.LastNameMinLength)]
        [MaxLength(DbValidationConstants.LastNameMinLength)]
        public string LastName { get; set; } = null!;
    }
}
