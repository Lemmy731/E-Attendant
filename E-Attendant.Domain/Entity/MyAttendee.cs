using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Attendant.Domain.Entity
{
    public class MyAttendee
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(10)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        public string? FirstName { get; set; }
        [Required]
        [StringLength(10)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        public string? LastName { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [Phone]
        public string? PhoneNumber { get; set; }
        public int Gender { get; set; } 
        public DateTime Date { get; set; } = DateTime.Now;
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; } = DateTime.Now;
        public int Stack { get; set; } 


    }
}
