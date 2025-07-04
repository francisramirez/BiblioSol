﻿using BiblioSol.Domain.Base;

namespace BiblioSol.Domain.Entities.users
{
    public sealed class Doctor : Person
    {
        public int DoctorId { get; set; }

        public short SpecialtyId { get; set; }

        public string LicenseNumber { get; set; }

        public string PhoneNumber { get; set; }

        public int YearsOfExperience { get; set; }

        public string Education { get; set; }

        public string Bio { get; set; }

        public decimal? ConsultationFee { get; set; }

        public string ClinicAddress { get; set; }

        public short? AvailabilityModeId { get; set; }

        public DateOnly LicenseExpirationDate { get; set; }
    }
    
}
