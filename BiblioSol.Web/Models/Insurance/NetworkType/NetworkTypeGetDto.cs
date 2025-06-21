namespace BiblioSol.Web.Models.Insurance.NetworkType
{
    public record NetworkTypeGetDto 
    {
        public int NetworkTypeId { get; set; }
        public string Name { get; init; } = string.Empty;
        public string Description { get; init; } = string.Empty;
        public DateTime CreatedAt { get; set; }
      
    }
}
