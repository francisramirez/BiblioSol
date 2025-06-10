
using BiblioSol.Domain.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BiblioSol.Domain.Entities.insurance
{
    [Table("NetworkType", Schema = "Insurance")]
    public sealed class NetworkType : AuditEntity
    {
        public NetworkType()
        {
            IsActive = true; // Default value for IsActive
        }

        [Key]
        public int NetworkTypeId { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }
    }
}
