using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Domain.Models
{
    public class User : IdentityUser
    {
        public ICollection<UserErrand> UserErrand { get; set; }
    }
}
