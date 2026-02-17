using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamHome.Infrastructure.Data.Models.Roles
{
    public class DreamHomeAdminRole : IdentityRole<Guid>
    {
        public DreamHomeAdminRole() : base() { }

        public DreamHomeAdminRole(string roleName)
            : base(roleName) { }
    }
}
