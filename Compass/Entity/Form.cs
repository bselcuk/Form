using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Compass.Entity
{
    public class Form
    {
        [Key]
        public int FormId { get; set; } 
        [Required]
        public string FormName { get; set; }

        public string FormUri { get; set; }

        public bool IsActive { get; set; } = true;
        public string UserCreated { get; set; }        
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public string UserUpdated { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
