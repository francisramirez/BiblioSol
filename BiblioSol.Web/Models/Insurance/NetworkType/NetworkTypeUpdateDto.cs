

namespace BiblioSol.Web.Models.Insurance.NetworkType
{
    public record NetworkTypeUpdateDto : NetworkTypeDto
    {
        public int Id { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int NetworkTypeId { get { return this.Id; } }


       
    }
}
