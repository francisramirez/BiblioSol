

namespace BiblioSol.Domain.Base
{
    public abstract class Person : AuditEntity
    {
        public int PersonId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateOnly? DateOfBirth { get; set; }

        public string IdentificationNumber { get; set; }

        public string Gender { get; set; }
    }
}
