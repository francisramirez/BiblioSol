

namespace BiblioSol.Domain.Base
{
    public abstract class AuditEntity
    {
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
       public bool IsActive { get; set; } = false;
      
    }
}
