using BiblioSol.Domain.Base;

namespace BiblioSol.Domain.Entities.users
{
    public sealed class Patient : Person
    {

        public int PatientId { get; set; }

        public string Gender { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string EmergencyContactName { get; set; }

        public string EmergencyContactPhone { get; set; }

        public string BloodType { get; set; }

        public string Allergies { get; set; }

        public int InsuranceProviderId { get; set; }

    }
}
