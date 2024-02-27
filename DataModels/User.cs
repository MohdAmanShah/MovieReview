using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class ApplicationUser:IdentityUser
    {
        public string Name { get; set; }
        public string? ImageUrl { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
