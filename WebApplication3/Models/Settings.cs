using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Settings
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Address { get; set; }
        [MaxLength(50)]
        public string Phone { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
         
    }
}
