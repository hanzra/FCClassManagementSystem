using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCCClassManagementSystem.Domain.Entities
{
    public class User : IdentityUser
    {
        [Required]        
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [ForeignKey("RegistrationID")]
        public virtual ICollection<Registration> Registration { get; set; }
    }
}
