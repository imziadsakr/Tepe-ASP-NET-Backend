using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_API.Models
{
    [Table("Patient")]
    public class Patient
    {
        [Key]
        [Display(Name = "UID")]
        public int? UID { get; set; }

        [Required]
        [Display(Name = "Email")]
        [Column(TypeName = "varchar(50)")]

        public string Email { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Phone")]
        [Column(TypeName = "varchar(50)")]

        public string Phone { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Comment")]
        [Column(TypeName = "varchar(50)")]

        public string Comment { get; set; } = string.Empty;

        [Required]
        [Display(Name = "TeethPhoto")]
        [Column(TypeName = "varchar(50)")]

        public string TeethPhoto { get; set; } = String.Empty;

        [Required]
        [Display(Name = "Recommendation")]
        [Column(TypeName = "varchar(50)")]

        public string Recommendation { get; set; } = string.Empty;

        [Required]
        [Display(Name = "BridgeAndMissingTeeth")]
        [Column(TypeName = "varchar(50)")]

        public string BridgeAndMissingTeeth { get; set; } = string.Empty;
    }
}
