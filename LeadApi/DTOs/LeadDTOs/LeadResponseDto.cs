namespace LeadApi.DTOs.LeadDTOs
{
    public class LeadResponseDto
    {
        public int LeadID { get; set; }

        public string FullName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public int? PropertyID { get; set; }

        public string Source { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;

        public int? AssignedAgentID { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
