using System.ComponentModel.DataAnnotations;

namespace DxThemeVariablesExample.Models
{
    public class Customer
    {
        [Required]
        [MinLength(3, ErrorMessage = "Name is too short.")]
        public string Name { get; set; }
        public int? Age { get; set; }
    }
}
