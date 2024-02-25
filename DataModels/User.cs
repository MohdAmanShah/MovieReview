using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class User:IdentityUser
    {
        public string Name { get; set; }
        public string? ImageUrl { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
