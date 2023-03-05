using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_API.Models
{
    public class PatientViewModel
    {
        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Phone { get; set; } = string.Empty;

        [Required]
        public string Comment { get; set; } = string.Empty;

        [Required]
        public IFormFile TeethPhoto { get; set; }

        [Required]
        public string Recommendation { get; set; } = string.Empty;

        [Required]
        public string BridgeAndMissingTeeth { get; set; } = string.Empty;
    }

}
