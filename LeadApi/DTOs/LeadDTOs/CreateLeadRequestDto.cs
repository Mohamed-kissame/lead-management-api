using System.ComponentModel.DataAnnotations;

namespace LeadApi.DTOs.LeadDTOs
{
    public class CreateLeadRequestDto
    {

        [Required]
        [StringLength(100)]
        public string FullName { get; set; } = string.Empty;

        [Required] [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Phone]
        public string Phone { get; set; } = string.Empty;

        public int? PropertyID { get; set; } = null;

        [Required]
        public string Source { get; set; } = string.Empty;
    }
}
