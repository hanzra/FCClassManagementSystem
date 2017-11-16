using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCCClassManagementSystem.Domain.Entities
{
   public class FitnessClass
    {
        public FitnessClass()
        {
            schedule = new List<Schedule>();
        }
        [Key]
        [Required]
        public int ClassID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public string Instructor { get; set; }
        public virtual IEnumerable<Schedule> schedule { get; set; }        
    
    }
}
