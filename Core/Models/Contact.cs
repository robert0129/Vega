using System.ComponentModel.DataAnnotations;

namespace WebApplicationBasic.Core.Models
{
    public class Contact
    {
        [Required]
        [StringLengthAttribute(255)]
        public string ContactName { get; set; }
        [Required]
        [Phone]
        [StringLengthAttribute(255)]
        public string ContactPhone { get; set; }
        [Required]
        [EmailAddress]
        [StringLengthAttribute(255)]
        public string ContactEmail { get; set; }
    }
}