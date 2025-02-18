using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ClipShare.Core.Entities
{
    public class AppUser : IdentityUser<int>
    {
        [Required]
        public string Name { get; set; }
        
        public DateTime CreatedTime { get; set; } = DateTime.Now;

        //Navigations
        public Channel Channel { get; set; }
    }
}
