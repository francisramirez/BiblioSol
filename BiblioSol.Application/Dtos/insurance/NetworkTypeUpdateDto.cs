

namespace BiblioSol.Application.Dtos.insurance
{
    public record NetworkTypeUpdateDto : NetworkTypeDto
    {
        public int Id { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
